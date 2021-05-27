using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;

namespace XmlExport.Model.FromRevit
{
    class RevitFamilyInstance : BaseGeometry<DtoExtrude>
    {
        public override List<DtoExtrude> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {
            List<ElementFilter> filters = new List<ElementFilter>();
            filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_Walls));
            filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_StructuralFoundation));

            LogicalOrFilter logFil1 = new LogicalOrFilter(filters);
            var familyInstanceList = new FilteredElementCollector(document, document.ActiveView.Id)
                .WherePasses(logFil1)
                .WhereElementIsNotElementType()
                .OfClass(typeof(FamilyInstance))
                .Cast<FamilyInstance>()
                .Where(r => true).ToList();

            Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);

            List<DtoExtrude> dtoFamilyInstances = new List<DtoExtrude>();

            if (!familyInstanceList.Any())
                return dtoFamilyInstances;

            foreach (var familyInstance in familyInstanceList)
            {

                if (familyInstance.Category.Id == document.Settings.Categories.get_Item(BuiltInCategory.OST_Walls).Id)
                {
                    var walls = CreateWallExctrude(document, familyInstance, rotationAtPoint, basePointXyz);
                    dtoFamilyInstances.AddRange(walls);
                }

                if (familyInstance.Category.Id == document.Settings.Categories.get_Item(BuiltInCategory.OST_StructuralFoundation).Id)
                {
                    var foundation = CreateFoundationExctrude(document, familyInstance, rotationAtPoint, basePointXyz, opt);
                    dtoFamilyInstances.Add(foundation);
                }

            }


            return dtoFamilyInstances;



        }

        private List<DtoExtrude> CreateWallExctrude(Document document, FamilyInstance familyInstance,
                                              Transform rotationAtPoint, XYZ basePointXyz)
        {
            var boundaries = GetBroundariesFromFamilyInstanceContext(document, familyInstance, rotationAtPoint);
            var floorBaseOffset = familyInstance.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();
            List<DtoExtrude> extrudeList = new List<DtoExtrude>();
            
            foreach (var boundary in boundaries)
            {
                DtoExtrude dtoExtrude = new DtoExtrude();
                dtoExtrude.BasePoint = basePointXyz;
                dtoExtrude.Name = familyInstance.Name;
                dtoExtrude.Element = familyInstance;
                dtoExtrude.BaseOffset = floorBaseOffset;

                double elevation = 0;

                if (familyInstance.get_Parameter(BuiltInParameter.INSTANCE_ELEVATION_PARAM) != null)
                {
                    elevation = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_ELEVATION_PARAM).AsDouble();
                }

                dtoExtrude.Elevation = elevation;
                dtoExtrude.PreparedElevation = BaseInfo.PreparedLevelDescription(elevation * 304.8 / 1000);
                dtoExtrude.Thickness = boundary.Length;
                dtoExtrude.Name = familyInstance.Name;
                dtoExtrude.BuildingName = BaseInfo.GetKksBuildNumber(document);
                dtoExtrude.Boundaries = boundaries;
                extrudeList.Add(dtoExtrude);

            }

            return extrudeList;
        }

        private DtoExtrude CreateFoundationExctrude(Document document, FamilyInstance familyInstance,
            Transform rotationAtPoint, XYZ basePointXyz, Options opt)
        {
            var boundaries = GetColumnProfile2(familyInstance, opt, rotationAtPoint);
            var floorBaseOffset = familyInstance.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();

            DtoExtrude dtoExtrude = new DtoExtrude();
            dtoExtrude.BasePoint = basePointXyz;
            dtoExtrude.Name = familyInstance.Name;
            dtoExtrude.Element = familyInstance;
            dtoExtrude.BaseOffset = floorBaseOffset;

            double elevation = 0;
            if (familyInstance.LevelId.IntegerValue != -1)
                elevation = document.GetElement(familyInstance.LevelId).get_Parameter(BuiltInParameter.LEVEL_ELEV)
                    .AsDouble();

            dtoExtrude.Elevation = elevation;
            dtoExtrude.PreparedElevation = BaseInfo.PreparedLevelDescription(elevation * 304.8 / 1000);
            dtoExtrude.Thickness = GetHeighByBoundingBox(familyInstance);
            dtoExtrude.Name = familyInstance.Name;
            dtoExtrude.BuildingName = BaseInfo.GetKksBuildNumber(document);
            dtoExtrude.Boundaries = boundaries;

            return dtoExtrude;
        }

    }
}
