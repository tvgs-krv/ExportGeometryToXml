using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;

namespace XmlExport.Model.FromRevit
{
    public class RevitColumn : BaseGeometry<DtoExtrude>
    {
        public override List<DtoExtrude> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {

            List<ElementFilter> filters = new List<ElementFilter>();
            filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_StructuralColumns));
            filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_Columns));
            LogicalOrFilter logFil1 = new LogicalOrFilter(filters);
            IEnumerable<Element> columns = new FilteredElementCollector(document, document.ActiveView.Id)
                .WherePasses(logFil1)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => true).ToList();

            Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);

            List<DtoExtrude> dtoFloors = new List<DtoExtrude>();

            if (!columns.Any()) 
                return dtoFloors;

            foreach (var element in columns)
            {
                var familyInstance = (FamilyInstance)element;
                var boundaries = GetColumnProfile(familyInstance, opt, rotationAtPoint);
                var floorBaseOffset = familyInstance.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();
                DtoExtrude dtoColumn = new DtoExtrude();
                dtoColumn.BasePoint = basePointXyz;
                dtoColumn.Name = familyInstance.Name;
                dtoColumn.Element = familyInstance;
                dtoColumn.BaseOffset = floorBaseOffset;
                double elevation = 0;
                if (familyInstance.LevelId.IntegerValue != -1)
                {
                    elevation = document.GetElement(familyInstance.LevelId).get_Parameter(BuiltInParameter.LEVEL_ELEV).AsDouble();
                }

                if(familyInstance.get_Parameter(BuiltInParameter.INSTANCE_REFERENCE_LEVEL_PARAM)!=null)
                {
                    var levelId = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_REFERENCE_LEVEL_PARAM)
                        .AsElementId();
                    elevation = document.GetElement(levelId).get_Parameter(BuiltInParameter.LEVEL_ELEV).AsDouble();
                }

                if (familyInstance.get_Parameter(BuiltInParameter.INSTANCE_ELEVATION_PARAM) != null)
                {
                    elevation = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_ELEVATION_PARAM).AsDouble();
                }



                dtoColumn.Elevation = elevation;
                dtoColumn.PreparedElevation = BaseInfo.PreparedLevelDescription(elevation * 304.8 / 1000);
                dtoColumn.Thickness = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_LENGTH_PARAM).AsDouble();
                dtoColumn.Name = familyInstance.Name;
                dtoColumn.BuildingName = BaseInfo.GetKksBuildNumber(document);
                dtoColumn.Boundaries = boundaries;
                dtoFloors.Add(dtoColumn);
            }
            return dtoFloors;
        }

    }
}
