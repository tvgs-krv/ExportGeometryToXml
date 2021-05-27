using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.IFC;
using Autodesk.Revit.UI;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;
using XmlExport.Model.Interfaces;

namespace XmlExport.Model.FromRevit
{
    public class RevitWallOpening : BaseGeometry<DtoBoundaries>
    {
        private readonly Logger _logger;

        public RevitWallOpening()
        {
            _logger = new Logger();
        }
        public List<DtoBoundaries> GetProfileFromOpening_Old(Wall wall, Transform rotationTransform)
        {
            XYZ normal = wall.Orientation.Normalize();

            Reference sideFaceReference = HostObjectUtils.GetSideFaces(wall, ShellLayerType.Exterior).First();
            Face face = wall.GetGeometryObjectFromReference(sideFaceReference) as Face;
            IList<CurveLoop> curveLoops = face.GetEdgesAsCurveLoops();
            Transform transform = Transform.CreateTranslation(wall.Orientation.Normalize());
            List<DtoBoundaries> bound = new List<DtoBoundaries>();

            var innerOpenings = CreateBoundariesFromCurveLoop(
                curveLoops, rotationTransform, normal, transform, false);
            bound.AddRange(innerOpenings);

            var hasElevationProfile = ExporterIFCUtils.HasElevationProfile(wall);

            if (hasElevationProfile)
            {
                var difference = CreateDifferenceBetweenSourceWallAndEditedWall(wall);
                var outerLoops = RetreiveCurveLoopFromSolid(difference);
                var outerOpenings = CreateBoundariesFromCurveLoop(
                    outerLoops, rotationTransform, normal, transform, true);
                bound.AddRange(outerOpenings);
            }

            else if (IsDoorInWall(wall))
            {
                var openinfFromDoor = DoorBoundaries(wall, transform);
                bound.AddRange(openinfFromDoor);
            }

            return bound;
        }

        public List<DtoBoundaries> GetProfileFromOpening(Wall wall, Transform rotationTransform)
        {
            List<DtoBoundaries> bound = new List<DtoBoundaries>();

            var hasElevationProfile = ExporterIFCUtils.HasElevationProfile(wall);
            Transform transform = Transform.CreateTranslation(wall.Orientation.Normalize());

            if (hasElevationProfile)
            {
                var openinfFromDoor = DoorBoundaries(wall, transform);
                bound.AddRange(openinfFromDoor);
            }

            if (IsDoorInWall(wall))
            {
                var openinfFromDoor = DoorBoundaries(wall, transform);
                bound.AddRange(openinfFromDoor);

            }

            return bound;
        }


        private DtoBoundaries ProjectArcToPlane(CurveLoop curves)
        {
            var plane = Plane.CreateByOriginAndBasis(curves.Last().GetEndPoint(0), XYZ.BasisX, XYZ.BasisY);
            DtoBoundaries b = new DtoBoundaries();
            b.NormalX = plane.Normal.X;
            b.NormalY = plane.Normal.Y;
            b.NormalZ = plane.Normal.Z;

            List<Curve> projectedCurves = new List<Curve>();
            foreach (Curve curve in curves)
            {
                XYZ previousPoint = null;
                for (var i = 0; i < curve.Tessellate().Count; i++)
                {
                    XYZ xyzProjected = plane.ProjectOnto(curve.Tessellate()[i]);
                    if (i == 0)
                        previousPoint = plane.ProjectOnto(xyzProjected);
                    else
                    {
                        projectedCurves.Add(Line.CreateBound(previousPoint, xyzProjected));
                        previousPoint = xyzProjected;
                    }
                }
            }
            b.Curves.AddRange(projectedCurves);
            return b;
        }

        private bool IsDoorInWall(Wall wall)
        {
            var inserts = wall.FindInserts(false, false, false, true);
            foreach (var elementId in inserts)
            {
                var element = wall.Document.GetElement(elementId);
                if (element.Category.Id == wall.Document.Settings.Categories.get_Item(BuiltInCategory.OST_Doors).Id)
                {
                    return true;
                }
            }

            return false;
        }

        private List<DtoBoundaries> DoorBoundaries(Wall wall, Transform transform)
        {
            var inserts = wall.FindInserts(false, false, false, true);
            List<FamilyInstance> doors = new List<FamilyInstance>();
            foreach (var elementId in inserts)
            {
                var element = wall.Document.GetElement(elementId);
                if (element.Category.Id == wall.Document.Settings.Categories.get_Item(BuiltInCategory.OST_Doors).Id)
                {
                    doors.Add(element as FamilyInstance);
                }
            }
            List<DtoBoundaries> doorsOpenings = new List<DtoBoundaries>();
            if (doors.Any())
            {
                foreach (var door in doors)
                {
                    var curveLoop = ExporterIFCUtils.GetInstanceCutoutFromWall(wall.Document, wall, door, out var direction);
                    var bounds = ConvertCurveLoopToBoundary(curveLoop, transform);
                    doorsOpenings.Add(bounds);
                }

            }

            return doorsOpenings;

        }

        private List<FamilyInstance> RetrieveDoorFromWall(Wall wall)
        {
            List<FamilyInstance> fi = new List<FamilyInstance>();
            var inserts = wall.FindInserts(false, false, false, true);
            foreach (var elementId in inserts)
            {
                var element = wall.Document.GetElement(elementId);
                if (element.Category.Id == wall.Document.Settings.Categories.get_Item(BuiltInCategory.OST_Doors).Id)
                {
                    fi.Add(element as FamilyInstance);
                }
            }

            return fi;
        }

        private Solid CreateDifferenceBetweenSourceWallAndEditedWall(Wall wall)
        {
            try
            {

                Options opt = new Options
                {
                    IncludeNonVisibleObjects = true
                };

                List<Face> faces = wall.get_Geometry(opt).Cast<Solid>()
                    .Where(x => x.Volume < 0.001)
                    .Select(x => x.Faces.get_Item(0))
                    .Where(x => x.ComputeNormal(UV.Zero)
                        .CrossProduct(wall.Orientation)
                        .IsAlmostEqualTo(XYZ.Zero))
                    .ToList();

                var sourceWall = CreateBlendGeometry(faces);
                var facesFromWall = FacesFromWall(wall);
                var changedWall = CreateBlendGeometry(facesFromWall);

                var difference = BooleanOperationsUtils
                    .ExecuteBooleanOperation(sourceWall, changedWall, BooleanOperationsType.Difference);

                return difference;
            }
            catch (Exception e)
            {
                _logger.WriteLineError(e.Message, wall, "OPENING");
            }

            return null;
        }

        private Solid CreateDifferenceBetweenSourceGeometryAndEditedGeometry(Wall wall)
        {
            if (!IsArc(wall))
            {
                try
                {
                    Options opt = new Options();

                    var solidWall = wall.get_Geometry(opt)
                        .Cast<Solid>().FirstOrDefault(x => x.Volume > 0.001);

                    var face = GetTopFace(solidWall);
                    var sourceWall = CreateExtrusionGeometry(face, wall);

                    var facesFromWall = FacesFromWall(wall);
                    var changedWall = CreateBlendGeometry(facesFromWall);

                    var difference = BooleanOperationsUtils
                        .ExecuteBooleanOperation(sourceWall, changedWall, BooleanOperationsType.Difference);

                    return difference;
                }
                catch (Exception e)
                {

                    _logger.WriteLineError(e.Message, wall, "OPENING");

                }

            }

            return null;

        }

        private List<Face> FacesFromWall(Wall wall)
        {
            Reference sideFaceReference1 = HostObjectUtils.GetSideFaces(wall, ShellLayerType.Exterior).First();
            Face face1 = wall.GetGeometryObjectFromReference(sideFaceReference1) as Face;

            Reference sideFaceReference2 = HostObjectUtils.GetSideFaces(wall, ShellLayerType.Interior).First();
            Face face2 = wall.GetGeometryObjectFromReference(sideFaceReference2) as Face;

            List<Face> faces = new List<Face>();
            faces.Add(face1);
            faces.Add(face2);
            return faces;
        }

        private IList<CurveLoop> RetreiveCurveLoopFromSolid(Solid solid)
        {
            if (solid != null && solid.Volume > 0 && solid.Faces.Size > 0)
            {
                Face face = solid.Faces.get_Item(0);
                var loops = face.GetEdgesAsCurveLoops();
                return loops;
            }

            return null;

        }


        private List<DtoBoundaries> CreateBoundariesFromCurveLoop(
            IList<CurveLoop> curveLoops, Transform rotationTransform,
            XYZ normal, Transform transform, bool isOuter)
        {
            List<DtoBoundaries> bound = new List<DtoBoundaries>();
            if (curveLoops != null && curveLoops.Any())
            {
                foreach (CurveLoop curveLoop in curveLoops)
                {
                    curveLoop.Transform(rotationTransform);
                    if (!curveLoop.IsCounterclockwise(normal) && !isOuter)
                    {
                        var inner = ConvertCurveLoopToBoundary(curveLoop, transform);
                        bound.Add(inner);
                    }

                    if (isOuter)
                    {
                        var outer = ConvertCurveLoopToBoundary(curveLoop, transform);
                        bound.Add(outer);

                    }

                }
            }

            return bound;
        }

        private DtoBoundaries ConvertCurveLoopToBoundary(CurveLoop curveLoop, Transform transform)
        {
            try
            {
                if (curveLoop.HasPlane())
                {
                    DtoBoundaries b = new DtoBoundaries();
                    var planeNormal = curveLoop.GetPlane().Normal;
                    b.NormalX = planeNormal.X;
                    b.NormalY = planeNormal.Y;
                    b.NormalZ = planeNormal.Z;
                    foreach (Curve curve in curveLoop)
                    {
                        Curve sourceCurve = curve.CreateTransformed(transform);
                        b.Curves.Add(sourceCurve);
                    }

                    return b;
                }
                else
                {
                    var b = ProjectArcToPlane(curveLoop);
                    return b;

                }

            }
            catch (Exception e)
            {
            }

            return new DtoBoundaries();

        }

        public override List<DtoBoundaries> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {
            throw new NotImplementedException();
        }


    }
}
