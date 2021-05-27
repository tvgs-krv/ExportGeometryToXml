using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;

namespace XmlExport.Model.FromRevit
{
    public class RevitWall : BaseGeometry<DtoAlongPath>
    {

        public override List<DtoAlongPath> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {

            var doors = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_Doors)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => true);
            List<DtoAlongPath> walls = new List<DtoAlongPath>();


            var w = RetrieveWall(document, basePointXyz, angle);
            walls.AddRange(w);
            return walls;
        }

        private List<DtoShiftOpening> GetOpeningsOnFloor(Document document)
        {
            var openingsOnFloor = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_GenericModel)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => true);
            List<DtoShiftOpening> filteredOpeningList = new List<DtoShiftOpening>();
            foreach (var opening in openingsOnFloor)
            {
                var openingBoundingBox = opening.get_BoundingBox(null);
                double openingBoundingBoxMinZ = openingBoundingBox.Min.Z;

                var getWallFromOpening = opening.Host;
                if (getWallFromOpening != null)
                {
                    var wallBoundingBox = getWallFromOpening.get_BoundingBox(null);
                    double wallBoundingBoxMinZ = wallBoundingBox.Min.Z;

                    if (openingBoundingBoxMinZ <= wallBoundingBoxMinZ)
                    {
                        var delta = wallBoundingBoxMinZ - openingBoundingBoxMinZ;
                        filteredOpeningList.Add(new DtoShiftOpening { Element = opening, Delta = delta });
                    }

                }

            }

            return filteredOpeningList;

        }
        private T GetWallLocation<T>(Wall wall)
        {

            if (wall.Location is LocationCurve locationCurve)
            {
                Curve curve = locationCurve.Curve;
                if (curve is T lineOrCurve)
                    return lineOrCurve;
            }
            return default;
        }


        private List<DtoAlongPath> RetrieveWall(Document document, XYZ basePointXyz, double angle)
        {
            var walls = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_Walls)
                .WhereElementIsNotElementType()
                .OfType<Wall>()
                .Where(r => true)
                .OrderByDescending(x => x.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble()).ToList();
            //Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);
            var newAxis = new XYZ(basePointXyz.X, basePointXyz.Y, basePointXyz.Z+1);
            Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);


            List<DtoAlongPath> dtoWalls = new List<DtoAlongPath>();
            string res = null;
            foreach (Wall wall in walls)
            {

                var height = wall.get_Parameter(BuiltInParameter.WALL_USER_HEIGHT_PARAM).AsDouble();
                var wallBaseOffset = wall.get_Parameter(BuiltInParameter.WALL_BASE_OFFSET).AsDouble();
                var wallTopOffset = wall.get_Parameter(BuiltInParameter.WALL_TOP_OFFSET).AsDouble();
                var item = new DtoAlongPath();
                item.BasePoint = basePointXyz;
                item.AnglePointRotation = angle;
                item.TopOffset = wallTopOffset;
                item.BaseOffset = wallBaseOffset;
                item.Name = wall.Name;
                item.Element = wall;
                var elev = document.GetElement(wall.LevelId).get_Parameter(BuiltInParameter.LEVEL_ELEV).AsDouble();
                item.Elevation = elev;
                item.PreparedElevation = BaseInfo.PreparedLevelDescription(elev * 304.8 / 1000);

                res += wall.Id + "\n";

                if (IsArc(wall))
                {
                    Arc getLocation = GetWallLocation<Arc>(wall);

                    var startP = getLocation.GetEndPoint(0);
                    var endP = getLocation.GetEndPoint(1);
                    var centerP = GetWallLocation<Arc>(wall).Evaluate(0.5, true);

                    item.StartPoint = GetRorationPointCoordinates(startP, rotationAtPoint);
                    item.EndPoint = GetRorationPointCoordinates(endP, rotationAtPoint);
                    item.AlongPoint = GetRorationPointCoordinates(centerP, rotationAtPoint);
                }
                else
                {
                    Line getLocation = GetWallLocation<Line>(wall);

                    var startP = getLocation.GetEndPoint(0);
                    var endP = getLocation.GetEndPoint(1);

                    item.StartPoint = GetRorationPointCoordinates(startP, rotationAtPoint);
                    item.EndPoint = GetRorationPointCoordinates(endP, rotationAtPoint);
                }
                item.Height = height;
                item.BuildingName = BaseInfo.GetKksBuildNumber(document);
                item.Width = wall.Width;
                item.Level = document.GetElement(wall.LevelId).Name;
                item.IsArc = IsArc(wall);
                var wallOpening = new RevitWallOpening();
                item.Boundaries = wallOpening.GetProfileFromOpening(wall, rotationAtPoint);
                dtoWalls.Add(item);
            }
            return dtoWalls;

        }

    }
}
