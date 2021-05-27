using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class SingleAttribute : IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }

        public string AttributeValue { get; set; }
        public string AttributeParameterName { get; set; }
        public string AttributeParameterValue { get; set; }

        public XElement CreateSingleAttribute()=> new XElement(Namespace + AttributeName, AttributeValue);
        public XElement CreateSingleAttributeWithParameter()
        {
            XElement xElement = new XElement(Namespace + AttributeName);

            XAttribute attribute = new XAttribute(AttributeParameterName, AttributeParameterValue);
            xElement.Add(attribute);
            return xElement;
        }
        public XElement CreateStructureXElement() => throw new NotSupportedException ();
    }
}
