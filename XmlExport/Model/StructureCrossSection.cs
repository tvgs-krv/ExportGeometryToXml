using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class StructureCrossSection : IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public string ReferenceStandard { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string CardinalPoint { get; set; }
        public bool Reflect { get; set; }
        public string Angle { get; set; }
        public string HorisontalOffset { get; set; }
        public string VerticalOffset { get; set; }
        public string Thickness { get; set; }
        public string Height { get; set; }
        public XElement CreateStructureXElement()
        {
            {
                XElement structXElement = new XElement(Namespace + "StructureCrossSection");
                XAttribute referenceStandard = new XAttribute("ReferenceStandard", ReferenceStandard);
                structXElement.Add(referenceStandard);
                XAttribute type = new XAttribute("Type", Type);
                structXElement.Add(type);
                XAttribute name = new XAttribute("Name", Name);
                structXElement.Add(name);

                structXElement.Add(new XElement(Namespace + "CardinalPoint", CardinalPoint));
                structXElement.Add(new XElement(Namespace + "Reflect", Reflect));
                structXElement.Add(new XElement(Namespace + "Angle", Angle));
                structXElement.Add(new XElement(Namespace + "HorisontalOffset", HorisontalOffset));
                structXElement.Add(new XElement(Namespace + "VerticalOffset", VerticalOffset));
                structXElement.Add(new XElement(Namespace + "Thickness", Thickness));
                structXElement.Add(new XElement(Namespace + "Height", Height));

                return structXElement;
            }

        }
    }
}
