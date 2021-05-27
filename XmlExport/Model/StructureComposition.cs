using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class StructureComposition:IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public string PartNumber { get; set; }
        public List<XElement> StructureCompositionCollection { get; set; }

        public XElement CreateStructureXElement()
        {
            XElement structXElement = new XElement(Namespace + "StructureComposition");
            XAttribute partNumber = new XAttribute("PartNumber", PartNumber);
            structXElement.Add(partNumber);


            foreach (var structCompositionElement in StructureCompositionCollection)
            {
                structXElement.Add(structCompositionElement);
            }
            return structXElement;
        }
    }
}
