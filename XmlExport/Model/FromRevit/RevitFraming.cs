using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;

namespace XmlExport.Model.FromRevit
{
    public class RevitFraming : BaseGeometry<DtoExtrude>
    {
        public override List<DtoExtrude> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {

            var framings = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_StructuralFraming)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => true).ToList();

            Transform rotationAtPoint = Transform.CreateRotationAtPoint(XYZ.BasisZ, angle, basePointXyz);

            List<DtoExtrude> dtoExtrudes = new List<DtoExtrude>();
            if (framings.Any())
            {
                foreach (var familyInstance in framings)
                {
                    var boundaries = GetColumnProfile(familyInstance, opt, rotationAtPoint);
                    var floorBaseOffset = familyInstance.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM).AsDouble();
                    DtoExtrude dtoFraming = new DtoExtrude();
                    dtoFraming.BasePoint = basePointXyz;
                    dtoFraming.Name = familyInstance.Name;
                    dtoFraming.Element = familyInstance;
                    dtoFraming.BaseOffset = floorBaseOffset;
                    double elevation;
                    if (familyInstance.LevelId.IntegerValue != -1)
                    {
                        elevation = document.GetElement(familyInstance.LevelId).get_Parameter(BuiltInParameter.LEVEL_ELEV).AsDouble();
                    }
                    else
                    {
                        var levelId = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_REFERENCE_LEVEL_PARAM)
                            .AsElementId();
                        elevation = document.GetElement(levelId).get_Parameter(BuiltInParameter.LEVEL_ELEV).AsDouble();
                    }

                    dtoFraming.Elevation = elevation;
                    dtoFraming.PreparedElevation = BaseInfo.PreparedLevelDescription(elevation * 304.8 / 1000);

                    dtoFraming.Thickness = familyInstance.get_Parameter(BuiltInParameter.INSTANCE_LENGTH_PARAM).AsDouble();
                    dtoFraming.Name = familyInstance.Name;
                    dtoFraming.BuildingName = BaseInfo.GetKksBuildNumber(document);
                    dtoFraming.Boundaries = boundaries;
                    dtoExtrudes.Add(dtoFraming);
                }

            }
            return dtoExtrudes;
        }

    }
}
