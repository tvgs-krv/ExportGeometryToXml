using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Linq;
using Autodesk.Revit.DB;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class WallXmlStructure<T> : IElementCreate<T>
    {
        public XElement CreateXmlElement(T dataFromModel)
        {
            if (!(dataFromModel is WallToXmlData wallElement))
                throw new ArgumentNullException(nameof(wallElement));


            XNamespace ns = wallElement.Namespace;

            XElement xe = new XElement(ns + "SPSWallPart");
            var guid = new XElement(ns + "OID", Guid.NewGuid().ToString());
            var wallName = new XElement(ns + "Name", wallElement.Name);

            #region Parents

            //var parent = new Parent
            //{
            //    Namespace = ns,
            //    Name = new XElement(ns+"Name", wallElement.Name),
            //    Oid = new XElement(ns+"OID", Guid.NewGuid().ToString()),
            //    SystemType = new XElement(ns+"SystemType", new XAttribute(ns+"SystemType", wallElement.SystemType)),
            //};
            //var par = parent.CreateStructureXElement();
            //var parentCollection = new List<XElement> {par, par, par};
            //var parents = new Parents{Namespace = ns, ParentCollection = parentCollection}.CreateStructureXElement();



            #endregion
            //var coordinateSystem = new XElement(ns + "CoordinateSystem", wallElement.BuildingName);
            var coordinateSystem = new XElement(ns + "CoordinateSystem", "CS_exportTest");
            var structureType = new XElement(ns + "StructureType", new XAttribute("PartNumber", wallElement.StructureType));

            #region StructureComposition

            //var layer1 = new Layer
            //{
            //    Namespace = ns,
            //    PartNumber = "B25/F100/W6/D2500_15.74804&quot;",
            //    Id = "1",
            //    MaterialType = "Тяжелый бетон/Heavy concrete",
            //    MaterialGrade = "B25/F100/W6/D2500",
            //    Thickness = "0.4",
            //    IsReference = true

            //};
            //var createLayer = wallElement.WalLayer.CreateStructureXElement();

            //var structureCompositionCollection = new List<XElement>{createLayer,createLayer};

            //var structureComposition = new StructureComposition
            //{
            //    Namespace = ns,
            //    PartNumber = "B25/F100/W6/D2500-WL",
            //    StructureCompositionCollection = structureCompositionCollection
            //};


            #endregion

            #region StructureCrossSection

            //var structureCrossSection = new StructureCrossSection
            //{
            //    Namespace = ns,
            //    ReferenceStandard = "Wall Cross-Sections",
            //    Type = "Rect",
            //    Name = "Rect_3500x0400",
            //    CardinalPoint = "3",
            //    Reflect = false,
            //    Angle = "5",
            //    HorisontalOffset = "5",
            //    VerticalOffset = "3",
            //    Height = "3"
            //};

            #endregion

            #region CreatePath
            List<XElement> line3dCollection = new List<XElement>();
            Line3D line3D = new Line3D(ns, wallElement.StartPoint, wallElement.EndPoint);
            var createLine3D = line3D.CreateStructureXElement();
            line3dCollection.Add(createLine3D);
            Path path = new Path(ns, line3dCollection);
            var createPath = path.CreateStructureXElement();
            #endregion


            xe.Add(guid);
            xe.Add(wallName);
            if (wallElement.WallParents != null) xe.Add(wallElement.WallParents.CreateStructureXElement());
            xe.Add(coordinateSystem);
            xe.Add(structureType);
            xe.Add(wallElement.WallStructureComposition.CreateStructureXElement());
            xe.Add(wallElement.WallStructureCrossSection.CreateStructureXElement());
            xe.Add(createPath);
            return xe;
        }

    }
}
