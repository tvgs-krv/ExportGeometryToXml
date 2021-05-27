using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class WallToXmlData : IInteractionWithModel
    {

        public XNamespace Namespace { get; set; }
        public string SystemType { get; set; }
        public string StructureType { get; set; }
        public string BuildingName { get; set; }
        public Parent WallParent { get; set; }
        public Parents WallParents { get; set; }
        public Layer WalLayer { get; set; }
        public StructureComposition WallStructureComposition { get; set; }
        public StructureCrossSection WallStructureCrossSection { get; set; }

        public Element Element { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public double Height { get; set; }
        public Point3D StartPoint { get; set; }
        public Point3D EndPoint { get; set; }
        public XYZ AlongPoint { get; set; }
        public bool IsArc { get; set; }

        public XElement GetDataFromModel<T>(T model)
        {
            if (!(model is Wall wall))
                throw new ArgumentNullException(nameof(wall));
            XNamespace ns = "urn:S3DIntegration";
            var getLocation = GetWallLocation(wall);
            var getStartPointX = ConvertUnits(getLocation.GetEndPoint(0).X)/1000;
            var getStartPointY = ConvertUnits(getLocation.GetEndPoint(0).Y)/1000;
            var getStartPointZ = ConvertUnits(getLocation.GetEndPoint(0).Z)/1000;
            var getEndPointX = ConvertUnits(getLocation.GetEndPoint(1).X)/1000;
            var getEndPointY = ConvertUnits(getLocation.GetEndPoint(1).Y)/1000;
            var getEndPointZ = ConvertUnits(getLocation.GetEndPoint(1).Z)/1000;
            var height = ConvertUnits(wall.get_Parameter(BuiltInParameter.WALL_USER_HEIGHT_PARAM).AsDouble())/1000;
            var wallBaseOffset = ConvertUnits(wall.get_Parameter(BuiltInParameter.WALL_BASE_OFFSET).AsDouble()) / 1000;
            var wallTopOffset = ConvertUnits(wall.get_Parameter(BuiltInParameter.WALL_TOP_OFFSET).AsDouble()) / 1000;
            var verticalOffset = wallBaseOffset + wallTopOffset;

            WallStructureCrossSection = new StructureCrossSection
            {
                Namespace = ns,
                ReferenceStandard = "Wall Cross-Sections",
                Type = "Rect",
                //Name = wall.WallType.Name,
                Name = "Rect_3500x0400",
                CardinalPoint = "3",
                Reflect = false,
                Angle = "0",
                HorisontalOffset = "0",
                VerticalOffset = "0",
                Thickness = "0.4",
                //VerticalOffset = verticalOffset.ToString(CultureInfo.CurrentCulture),
                Height = height.ToString(CultureInfo.CurrentCulture)
            };



            var createLayer = GetMaterialFromWall(ns, wall).CreateStructureXElement();

            var structureCompositionCollection = new List<XElement> { createLayer };

            var structureComposition = new StructureComposition
            {
                Namespace = ns,
                PartNumber = "B25/F100/W6/D2500-WL",
                StructureCompositionCollection = structureCompositionCollection
            };


            WallToXmlData wallToXmlData = new WallToXmlData
            {
                Namespace = ns,
                Name = wall.Name,
                BuildingName = wall.Document.Title,
                WallStructureCrossSection = WallStructureCrossSection,
                WallStructureComposition = structureComposition,
                StartPoint = new Point3D(ns, getStartPointX, getStartPointY, getStartPointZ),
                EndPoint = new Point3D(ns, getEndPointX, getEndPointY, getEndPointZ),
                Height = height,
                StructureType = "Монолитная ЖБ стена/Solid Wall",
                SystemType = "CPAreaSystem"

            };

            WallXmlStructure<WallToXmlData> wallXml = new WallXmlStructure<WallToXmlData>();

            return wallXml.CreateXmlElement(wallToXmlData);


        }

        private Line GetWallLocation(Wall wall)
        {

            if (wall.Location is LocationCurve locationCurve)
            {
                Curve curve = locationCurve.Curve;
                if (curve is Line line) return line;
            }
            return null;

        }

        private Layer GetMaterialFromWall(XNamespace ns, Wall wall)
        {
            var gatMaterialIds = wall.GetMaterialIds(false).FirstOrDefault();
            Material mat = wall.Document.GetElement(gatMaterialIds) as Material;

            var layer = new Layer
            {
                Namespace = ns,
                PartNumber = "B30/F050/W6/D2500_15.74804",
                //PartNumber = mat.Name,
                Id = mat.Id.ToString(),
                MaterialType = "Тяжелый бетон/Heavy concrete",
                //MaterialType = mat.MaterialCategory,
                MaterialGrade = "B30/F050/W6/D2500",
                Thickness = "0.4",
                IsReference = true

            };
            return layer;

        }

        private double ConvertUnits(double dOffsetInches)
        {
            return UnitUtils.Convert(dOffsetInches, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS);
        }


    }
}
