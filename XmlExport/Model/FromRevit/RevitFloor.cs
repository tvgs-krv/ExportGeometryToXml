using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;

namespace XmlExport.Model.FromRevit
{
    public class RevitFloor : BaseGeometry<DtoExtrude>
    {
        public override List<DtoExtrude> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {
            var floors = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_Floors)
                .WhereElementIsNotElementType()
                .OfType<Floor>()
                .Where(r => true).ToList();

            List<DtoExtrude> dtoFloors = new List<DtoExtrude>();

            Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);

            foreach (Floor floor in floors)
            {
                List<DtoBoundaries> boundaries = new List<DtoBoundaries>();
                GeometryElement geo = floor.get_Geometry(opt);
                List<Curve> curves = new List<Curve>();
                foreach (GeometryObject obj in geo)
                {
                    Solid solid = obj as Solid;
                    
                    if (solid != null)
                    {
                        boundaries = GetBoundaries(solid, rotationAtPoint).OrderBy(a => a.Area).ToList();
                    }
                }

                var floorBaseOffset = floor.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();
                
                DtoExtrude dtoExtrude = new DtoExtrude();

                dtoExtrude.BasePoint = basePointXyz;
                dtoExtrude.Name = floor.Name;
                dtoExtrude.Element = floor;
                dtoExtrude.BaseOffset = floorBaseOffset;
                var elevation = document.GetElement(floor.LevelId).get_Parameter(BuiltInParameter.LEVEL_ELEV)
                    .AsDouble();
                dtoExtrude.Elevation = elevation;
                dtoExtrude.PreparedElevation = BaseInfo.PreparedLevelDescription(elevation * 304.8 / 1000);

                dtoExtrude.Thickness = floor.get_Parameter(BuiltInParameter.FLOOR_ATTR_THICKNESS_PARAM).AsDouble();
                dtoExtrude.Name = floor.Name;
                dtoExtrude.BuildingName = BaseInfo.GetKksBuildNumber(document);
                dtoExtrude.Boundaries = boundaries;
                dtoFloors.Add(dtoExtrude);
            }

            var floorsFi = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_Floors)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => r.get_Parameter(BuiltInParameter.HOST_AREA_COMPUTED).HasValue)
                .ToList();

            Options opt2 = new Options { DetailLevel = ViewDetailLevel.Fine, IncludeNonVisibleObjects = true };

            foreach (var floor in floorsFi)
            {
                GeometryElement geo = floor.get_Geometry(opt2);
                foreach (GeometryObject obj in geo)
                {
                    var geometryInstance = obj as GeometryInstance;
                    if (geometryInstance != null)
                    {
                        var tr = floor.GetTotalTransform();

                        var g = geometryInstance.GetInstanceGeometry(tr);
                        List<DtoBoundaries> boundaries = new List<DtoBoundaries>();
                        double elev = 0;
                        double thick = 0;

                        foreach (var s in g)
                        {
                            var ss = s as Solid;
                            if (ss != null && ss.SurfaceArea > 0)
                            {

                                //boundaries = GetBoundaries(ss).OrderBy(a => a.Area).ToList();
                                boundaries = GetBoundaries2(ss).OrderBy(a => a.Area).ToList();
                                var bb = ss.GetBoundingBox();
                                thick = bb.Max.Z - bb.Min.Z;
                                elev = bb.Min.Z;
                                DtoExtrude dtoFloor2 = new DtoExtrude();
                                dtoFloor2.BasePoint = basePointXyz;
                                dtoFloor2.Name = floor.Name;
                                dtoFloor2.Element = floor;
                                dtoFloor2.BaseOffset = floor.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();
                                dtoFloor2.Elevation = elev;
                                dtoFloor2.PreparedElevation = BaseInfo.PreparedLevelDescription(elev * 304.8 / 1000);
                                dtoFloor2.Thickness = thick;
                                dtoFloor2.Name = floor.Name;
                                dtoFloor2.BuildingName = BaseInfo.GetKksBuildNumber(document);
                                dtoFloor2.Boundaries = boundaries;
                                dtoFloors.Add(dtoFloor2);
                            }

                        }



                    }
                }

            }

            return dtoFloors;

        }

    }


}
