using System.Xml.Linq;

namespace XmlExport.Abstraction
{
    interface IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        XElement CreateStructureXElement();
    }
}
