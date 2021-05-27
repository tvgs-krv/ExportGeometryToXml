using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Parents : IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public List<XElement> ParentCollection { get; set; }



        public XElement CreateStructureXElement()
        {
            XElement parentsXElement = new XElement(Namespace + "Parents");

            foreach (var parent in ParentCollection)
            {
                parentsXElement.Add(parent);
            }
            return parentsXElement;
        }

    }
}
