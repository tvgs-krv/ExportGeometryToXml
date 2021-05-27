using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.IFC;
using Autodesk.Revit.UI;
using XmlExport.Model.Dto;

namespace XmlExport.Model.Abstraction
{
    public abstract class BaseGeometry<T>
    {
        #region Public Methods
        public abstract List<T> ToDto(Document document, Options opt, XYZ basePointXyz, double angle);

        public List<DtoBoundaries> GetColumnProfile(FamilyInstance familyInstance, Options opt)
        {
            List<DtoBoundaries> result = new List<DtoBoundaries>();
            Transform totalTransform = familyInstance.GetTotalTransform();

            if (familyInstance.HasSweptProfile())
            {
                SweptProfile swept = familyInstance.GetSweptProfile();
                var derivatives = swept.GetDrivingCurve().ComputeDerivatives(0.5, true);
                var plane = Plane.CreateByNormalAndOrigin(derivatives.BasisX.Normalize(), derivatives.Origin);
                var transform = Transform.Identity;
                transform.Origin = plane.Origin;
                transform.BasisX = plane.XVec;
                transform.BasisY = plane.YVec;
                transform.BasisZ = plane.Normal;
                var profile = swept.GetSweptProfile();
                var curveEnum = profile.Curves.Cast<Curve>().Select(w => w.CreateTransformed(transform));
                DtoBoundaries curveArray = new DtoBoundaries();
                curveArray.NormalX = plane.Normal.X;
                curveArray.NormalY = plane.Normal.Y;
                curveArray.NormalZ = plane.Normal.Z;
                curveArray.Curves.AddRange(curveEnum);
                result.Add(curveArray);

            }

            else
            {
                GeometryElement geometryElement = familyInstance.get_Geometry(opt);
                foreach (GeometryObject geometryObject in geometryElement)
                {
                    if (geometryObject is GeometryInstance geometryInstance)
                    {
                        var geoElem = geometryInstance.SymbolGeometry;
                        if (geoElem != null && geoElem.Any())
                        {
                            var solid = geoElem
                                .Where(s => s.IsElementGeometry)
                                .Cast<Solid>()
                                .First(s => s.SurfaceArea > 0);
                            result = GetBoundaries(solid, totalTransform).OrderBy(a => a.Area).ToList();

                        }
                    }
                }
            }
            return result;
        }

        public List<DtoBoundaries> GetColumnProfile2(FamilyInstance familyInstance, Options opt, Transform rotationTransform)
        {
            List<DtoBoundaries> result = new List<DtoBoundaries>();
            Transform totalTransform = familyInstance.GetTotalTransform();


            if (familyInstance.HasSweptProfile())
            {

                SweptProfile swept = familyInstance.GetSweptProfile();
                var derivatives = swept.GetDrivingCurve().ComputeDerivatives(0.5, true);
                var plane = Plane.CreateByNormalAndOrigin(derivatives.BasisX.Normalize(), derivatives.Origin);
                var transform = Transform.Identity;
                transform.Origin = plane.Origin;
                transform.BasisX = plane.XVec;
                transform.BasisY = plane.YVec;
                transform.BasisZ = plane.Normal;

                Profile profile = swept.GetSweptProfile();

                var curveEnum = profile.Curves.Cast<Curve>().Select(w => w.CreateTransformed(transform));
                var curveEnum2 = curveEnum.Select(w => w.CreateTransformed(rotationTransform));
                DtoBoundaries curveArray = new DtoBoundaries();
                curveArray.NormalX = plane.Normal.X;
                curveArray.NormalY = plane.Normal.Y;
                curveArray.NormalZ = plane.Normal.Z;
                curveArray.Curves.AddRange(curveEnum2);

                result.Add(curveArray);

            }

            else
            {
                GeometryElement geometryElement = familyInstance.get_Geometry(opt);
                foreach (GeometryObject geometryObject in geometryElement)
                {
                    if (geometryObject is GeometryInstance geometryInstance)
                    {
                        var geoElem = geometryInstance.SymbolGeometry;
                        if (geoElem != null && geoElem.Any())
                        {
                            var solid = geoElem
                                .Where(s => s.IsElementGeometry)
                                .Cast<Solid>()
                                .First(s => s.SurfaceArea > 0);
                            result = GetBoundaries(solid, totalTransform, rotationTransform)
                                .OrderBy(a => a.Area).ToList();

                        }
                    }
                }
            }
            return result;
        }

        public List<DtoBoundaries> GetColumnProfile(FamilyInstance familyInstance, Options opt, Transform rotationTransform)
        {
            List<DtoBoundaries> result = new List<DtoBoundaries>();

            if (familyInstance.HasSweptProfile())
            {

                SweptProfile swept = familyInstance.GetSweptProfile();
                var derivatives = swept.GetDrivingCurve().ComputeDerivatives(0.5, true);
                var plane = Plane.CreateByNormalAndOrigin(derivatives.BasisX.Normalize(), derivatives.Origin);
                var transform = Transform.Identity;
                transform.Origin = plane.Origin;
                transform.BasisX = plane.XVec;
                transform.BasisY = plane.YVec;
                transform.BasisZ = plane.Normal;

                Profile profile = swept.GetSweptProfile();

                var curveEnum = profile.Curves.Cast<Curve>().Select(w => w.CreateTransformed(transform));
                var curveEnum2 = curveEnum.Select(w => w.CreateTransformed(rotationTransform));
                DtoBoundaries curveArray = new DtoBoundaries();
                curveArray.NormalX = plane.Normal.X;
                curveArray.NormalY = plane.Normal.Y;
                curveArray.NormalZ = plane.Normal.Z;
                curveArray.Curves.AddRange(curveEnum2);

                result.Add(curveArray);

            }

            else
            {
                GeometryElement geometryElement = familyInstance.get_Geometry(opt);
                foreach (GeometryObject geometryObject in geometryElement)
                {
                    if (geometryObject is GeometryInstance geometryInstance)
                    {
                        var geoElem = geometryInstance.SymbolGeometry;
                        if (geoElem != null && geoElem.Any())
                        {
                            var solid = geoElem
                                .Where(s => s.IsElementGeometry)
                                .Cast<Solid>()
                                .First(s => s.SurfaceArea > 0);
                            result = GetBoundaries(solid, rotationTransform).OrderBy(a => a.Area).ToList();

                        }
                    }
                }
            }
            return result;
        }

        public List<DtoBoundaries> GetBroundariesFromFamilyInstanceContext(Document document,
            FamilyInstance familyInstance, Transform rotationTransform)
        {
            List<DtoBoundaries> result = new List<DtoBoundaries>();
            List<ElementId> deletedIds = new List<ElementId>();

            using (Transaction tr = new Transaction(familyInstance.Document))
            {
                tr.Start("Временное удаление элемента");

                deletedIds = familyInstance.Document.Delete(familyInstance.Id).ToList();

                tr.RollBack();
            }

            foreach (var elementId in deletedIds)
            {
                var bounds = GetSourceGeometryFromElement(document, elementId,
                    familyInstance.GetTotalTransform());
                result.AddRange(bounds);
            }

            return result;

        }

        public List<DtoBoundaries> GetSourceGeometryFromElement(Document document,
            ElementId elementId, Transform totalTransform)
        {
            List<DtoBoundaries> boundaries = new List<DtoBoundaries>();
            var element = document.GetElement(elementId);

            if (element is Extrusion extrusion)
            {
                var bound = GetExtrusion(extrusion, totalTransform);
                boundaries.Add(bound);
            }

            if (element is Sweep sweep)
            {
                var sw = GetSweep(sweep);
                boundaries.Add(sw);
            }

            return boundaries;
        }

        public double GetHeighByBoundingBox(Element element)
        {
            var boundingBox = element.get_BoundingBox(null);
            var height = boundingBox.Max.Z - boundingBox.Min.Z;
            return height;
        }
        public void GetSweptProfile(FamilyInstance familyInstance, Options opt)
        {
            List<DtoBoundaries> result = new List<DtoBoundaries>();
            Transform totalTransform = familyInstance.GetTotalTransform();

            if (familyInstance.HasSweptProfile())
            {
                SweptProfile swept = familyInstance.GetSweptProfile();
                var derivatives = swept.GetDrivingCurve().ComputeDerivatives(0.5, true);
                var plane = Plane.CreateByNormalAndOrigin(derivatives.BasisX.Normalize(), derivatives.Origin);
                var transform = Transform.Identity;
                transform.Origin = plane.Origin;
                transform.BasisX = plane.XVec;
                transform.BasisY = plane.YVec;
                transform.BasisZ = plane.Normal;
                var profile = swept.GetSweptProfile();
                var curveEnum = profile.Curves.Cast<Curve>().Select(w => w.CreateTransformed(transform));
                DtoBoundaries curveArray = new DtoBoundaries();
                curveArray.NormalX = plane.Normal.X;
                curveArray.NormalY = plane.Normal.Y;
                curveArray.NormalZ = plane.Normal.Z;
                curveArray.Curves.AddRange(curveEnum);
                result.Add(curveArray);
            }

        }

        public List<DtoBoundaries> GetBoundaries(Solid solid, Transform transform)
        {
            List<DtoBoundaries> resList = new List<DtoBoundaries>();
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == lowest || pf.Origin.Z < lowest.Origin.Z)
                        lowest = pf;
                }
            }
            if (null != lowest)
            {
                var normal = lowest.FaceNormal;
                EdgeArrayArray loops = lowest.EdgeLoops;
                foreach (EdgeArray loop in loops)
                {
                    List<Curve> curves = new List<Curve>();
                    List<XYZ> vertices = new List<XYZ>();
                    int i, n;
                    foreach (Edge e in loop)
                    {
                        IList<XYZ> points = e.Tessellate();
                        n = points.Count;
                        for (i = 0; i < n - 1; ++i)
                        {
                            XYZ v = points[i];
                            vertices.Add(v);
                        }
                        var c = e.AsCurve();
                        curves.Add(c.CreateTransformed(transform));

                    }
                    var flatten = Flatten(vertices);
                    var area = GetSignedPolygonArea(flatten);
                    //resList.Add(new DTOBoundaries { Area = area, Curves = curves });
                    resList.Add(new DtoBoundaries
                    {
                        Area = area,
                        Curves = curves,
                        NormalX = normal.X,
                        NormalY = normal.Y,
                        NormalZ = normal.Z
                    });

                }
            }
            return resList;
        }

        public List<DtoBoundaries> GetBoundaries(Solid solid, Transform transform, Transform rotationTransform)
        {
            List<DtoBoundaries> resList = new List<DtoBoundaries>();
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == lowest || pf.Origin.Z < lowest.Origin.Z)
                        lowest = pf;
                }
            }
            if (null != lowest)
            {
                var normal = lowest.FaceNormal;
                EdgeArrayArray loops = lowest.EdgeLoops;
                foreach (EdgeArray loop in loops)
                {
                    List<Curve> curves = new List<Curve>();
                    List<XYZ> vertices = new List<XYZ>();
                    int i, n;
                    foreach (Edge e in loop)
                    {
                        IList<XYZ> points = e.Tessellate();
                        n = points.Count;
                        for (i = 0; i < n - 1; ++i)
                        {
                            XYZ v = points[i];
                            vertices.Add(v);
                        }
                        var c = e.AsCurve();
                        Curve totalTransformCurve = c.CreateTransformed(transform);
                        var rotationTransformCurve = totalTransformCurve.CreateTransformed(rotationTransform);
                        curves.Add(rotationTransformCurve);

                    }
                    var flatten = Flatten(vertices);
                    var area = GetSignedPolygonArea(flatten);
                    //resList.Add(new DTOBoundaries { Area = area, Curves = curves });
                    resList.Add(new DtoBoundaries
                    {
                        Area = area,
                        Curves = curves,
                        NormalX = normal.X,
                        NormalY = normal.Y,
                        NormalZ = normal.Z
                    });

                }
            }
            return resList;
        }

        public List<DtoBoundaries> GetBoundaries(Solid solid)
        {
            List<DtoBoundaries> resList = new List<DtoBoundaries>();
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == lowest || pf.Origin.Z < lowest.Origin.Z)
                        lowest = pf;
                }
            }
            if (null != lowest)
            {
                EdgeArrayArray loops = lowest.EdgeLoops;
                var normal = lowest.FaceNormal;
                foreach (EdgeArray loop in loops)
                {

                    List<Curve> curves = new List<Curve>();
                    List<XYZ> vertices = new List<XYZ>();
                    foreach (Edge e in loop)
                    {
                        IList<XYZ> points = e.Tessellate();
                        var n = points.Count;
                        int i;
                        for (i = 0; i < n - 1; ++i)
                        {
                            XYZ v = points[i];
                            vertices.Add(v);
                        }
                        var c = e.AsCurve();

                        curves.Add(c);
                    }

                    var flatten = Flatten(vertices);
                    var area = GetSignedPolygonArea(flatten);

                    resList.Add(new DtoBoundaries
                    {
                        Area = area,
                        Curves = curves,
                        NormalX = normal.X,
                        NormalY = normal.Y,
                        NormalZ = normal.Z
                    });
                }
            }
            return resList;
        }

        public List<DtoBoundaries> GetBoundaries2(Solid solid)
        {
            List<DtoBoundaries> resList = new List<DtoBoundaries>();
            var lowest = GetBottomFace(solid);

            if (null != lowest)
            {
                EdgeArrayArray loops = lowest.EdgeLoops;
                var normal = lowest.FaceNormal;
                var curveLoops = lowest.GetEdgesAsCurveLoops();

                foreach (EdgeArray loop in loops)
                {

                    List<Curve> curves = new List<Curve>();
                    List<XYZ> vertices = new List<XYZ>();
                    foreach (Edge e in loop)
                    {
                        IList<XYZ> points = e.Tessellate();
                        var n = points.Count;
                        int i;
                        for (i = 0; i < n - 1; ++i)
                        {
                            XYZ v = points[i];
                            vertices.Add(v);
                        }
                        var c = e.AsCurve();

                        curves.Add(c);
                    }

                    var flatten = Flatten(vertices);
                    var area = GetSignedPolygonArea(flatten);

                    resList.Add(new DtoBoundaries
                    {
                        Area = area,
                        Curves = curves,
                        NormalX = normal.X,
                        NormalY = normal.Y,
                        NormalZ = normal.Z
                    });
                }
            }
            return resList;
        }




        private PlanarFace GetBottomFace(Solid solid)
        {
            PlanarFace bottomFace = null;
            FaceArray faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == bottomFace || bottomFace.Origin.Z > pf.Origin.Z)
                    {
                        bottomFace = pf;
                    }
                }
            }
            return bottomFace;
        }




        public PlanarFace GetFloorPlanarFace(Solid solid)
        {
            List<DtoBoundaries> resList = new List<DtoBoundaries>();
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == lowest || pf.Origin.Z < lowest.Origin.Z)
                        lowest = pf;
                }
            }
            return lowest;
        }

        public bool IsVertical(XYZ v)
        {
            return IsZero(v.X) && IsZero(v.Y);
        }


        public EdgeArray PlanarFaceOuterLoop(Face F)
        {
            PlanarFace face = F as PlanarFace;
            if (face == null)
            {
                return null;
            }
            Transform T = Transform.Identity;
            T.BasisZ = face.FaceNormal;
            T.BasisX = face.XVector;
            T.BasisY = face.YVector;
            T.Origin = face.Origin;
            Transform Tinv = T.Inverse;

            EdgeArray eaMin = null;
            EdgeArrayArray loops = F.EdgeLoops;
            double uMin = Double.MaxValue;
            foreach (EdgeArray a in loops)
            {
                double uMin2 = Double.MaxValue;
                foreach (Edge e in a)
                {
                    double min = MinX(e.AsCurve(), Tinv);
                    if (min < uMin2) { uMin2 = min; }
                }
                if (uMin2 < uMin)
                {
                    uMin = uMin2;
                    eaMin = a;
                }
            }
            return eaMin;
        }

        public XYZ GetRorationPointCoordinates(XYZ point, Transform transform)
        {
            return transform.OfPoint(point);
        }

        public Solid CreateBlendGeometry(List<Face> faces)
        {
            Face f1;
            Face f2;
            if (faces.Count > 3)
            {
                f1 = faces[1];
                f2 = faces[2];
            }
            else
            {
                f1 = faces[0];
                f2 = faces[1];
            }

            var curveLoop1 = f1.GetEdgesAsCurveLoops().FirstOrDefault();
            var curveLoop2 = f2.GetEdgesAsCurveLoops().FirstOrDefault();

            var solid = GeometryCreationUtilities
                .CreateBlendGeometry(curveLoop1, curveLoop2, null);

            return solid;
        }

        public Solid CreateExtrusionGeometry(Face face, Element element)
        {
            var cls = face.GetEdgesAsCurveLoops();
            var bb = element.get_BoundingBox(null);
            var wallHeight = bb.Max.Z - bb.Min.Z;
            var solid = GeometryCreationUtilities.CreateExtrusionGeometry(cls, -XYZ.BasisZ, wallHeight);
            return solid;
        }

        public Face GetTopFace(Solid solid)
        {
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && IsHorizontal(pf))
                {
                    if (null == lowest || pf.Origin.Z > lowest.Origin.Z)
                        lowest = pf;
                }
            }

            return lowest;
        }

        public Face GetVerticalFace(Solid solid)
        {
            PlanarFace lowest = null;
            var faces = solid.Faces;
            foreach (Face f in faces)
            {
                PlanarFace pf = f as PlanarFace;
                if (null != pf && !IsHorizontal(pf))
                {
                    if (null == lowest)
                        lowest = pf;
                }
            }

            return lowest;
        }

        public bool IsArc(Wall wall)
        {
            if (wall.Location is LocationCurve locationCurve)
            {
                Curve curve = locationCurve.Curve;
                if (curve is Line) return false;
            }
            return true;
        }




        #endregion



        #region Private Methods
        private const double Eps = 1.0e-9;

        private DtoBoundaries GetExtrusion(Extrusion extrusion, Transform totalTransform)
        {
            //TODO  Посадка покоординатам не корректна

            List<Curve> curves = new List<Curve>();

            var plane = extrusion.Sketch.SketchPlane.GetPlane();
            var transform = Transform.Identity;
            transform.Origin = plane.Origin;
            transform.BasisX = plane.XVec;
            transform.BasisY = plane.YVec;
            transform.BasisZ = plane.Normal;

            var profile = extrusion.Sketch.Profile;
            foreach (CurveArray curveAr in profile)
            {
                foreach (Curve curve in curveAr)
                {
                    curves.Add(curve.CreateTransformed(totalTransform));
                }
            }


            var extrusionEntity = new DtoBoundaries();
            extrusionEntity.NormalX = plane.Normal.X;
            extrusionEntity.NormalY = plane.Normal.Y;
            extrusionEntity.NormalZ = plane.Normal.Z;
            extrusionEntity.Curves = curves;
            extrusionEntity.Length = Math.Abs(extrusion.StartOffset - extrusion.EndOffset);
            return extrusionEntity;
        }

        private DtoBoundaries GetSweep(Sweep sweep)
        {
            List<Curve> profileCurves = new List<Curve>();
            List<Curve> pathCurves = new List<Curve>();
            foreach (CurveArray curveAr in sweep.ProfileSketch.Profile)
            {
                foreach (Curve curve in curveAr)
                {
                    profileCurves.Add(curve);
                }
            }

            foreach (CurveArray curveAr in sweep.PathSketch.Profile)
            {
                foreach (Curve curve in curveAr)
                {
                    pathCurves.Add(curve);
                }
            }

            var plane = sweep.ProfileSketch.SketchPlane.GetPlane();
            var transform = Transform.Identity;
            transform.Origin = plane.Origin;
            transform.BasisX = plane.XVec;
            transform.BasisY = plane.YVec;
            transform.BasisZ = plane.Normal;



            var sweepEntity = new DtoBoundaries();
            sweepEntity.NormalX = plane.Normal.X;
            sweepEntity.NormalY = plane.Normal.Y;
            sweepEntity.NormalZ = plane.Normal.Z;
            sweepEntity.Curves = profileCurves;
            sweepEntity.Length = pathCurves.First().Length;
            return sweepEntity;
        }
        List<UV> Flatten(List<XYZ> polygon)
        {
            double z = polygon[0].Z;
            List<UV> a = new List<UV>(polygon.Count);
            foreach (XYZ p in polygon)
            {
                a.Add(Flatten(p));
            }
            return a;
        }

        UV Flatten(XYZ point)
        {
            return new UV(point.X, point.Y);
        }

        private bool IsHorizontal(PlanarFace f)
        {
            return IsVertical(f.FaceNormal);
        }
        public bool IsZero(double a, double tolerance = Eps)
        {
            return tolerance > Math.Abs(a);
        }

        public bool IsVertical(PlanarFace f)
        {
            return IsHorizontal(f.FaceNormal);
        }

        public bool IsHorizontal(XYZ v)
        {
            return IsZero(v.Z);
        }

        private double GetSignedPolygonArea(List<UV> p)
        {
            int n = p.Count;
            double sum = p[0].U * (p[1].V - p[n - 1].V);
            for (int i = 1; i < n - 1; ++i)
            {
                sum += p[i].U * (p[i + 1].V - p[i - 1].V);
            }
            sum += p[n - 1].U * (p[0].V - p[n - 2].V);
            return 0.5 * sum;
        }

        private double MinU(Curve C, Face F)
        {
            return C.Tessellate()
                .Select<XYZ, IntersectionResult>(p => F.Project(p))
                .Min<IntersectionResult>(ir => ir.UVPoint.U);
        }

        private double MinX(Curve C, Transform Tinv)
        {
            return C.Tessellate()
                .Select<XYZ, XYZ>(p => Tinv.OfPoint(p))
                .Min<XYZ>(p => p.X);
        }


        #endregion











    }

}
