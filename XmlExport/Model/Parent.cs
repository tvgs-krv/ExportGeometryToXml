using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Parent : IXmlStructure
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }

        public XElement Oid { get; set; }
        public XElement Name { get; set; }
        public XElement SystemType { get; set; }

        public XElement CreateStructureXElement()
        {
            XElement parentXelement = new XElement(Namespace + "Parent");
            parentXelement.Add(Oid);
            parentXelement.Add(Name);
            parentXelement.Add(SystemType);
            return parentXelement;

        }

    }
}
