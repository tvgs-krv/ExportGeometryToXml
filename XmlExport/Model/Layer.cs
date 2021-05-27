using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Layer : ILayer
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }

        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string MaterialType { get; set; }
        public string MaterialGrade { get; set; }
        public string Thickness { get; set; }
        public bool IsReference { get; set; }


        public XElement CreateStructureXElement()
        {
            XElement parentXelement = new XElement(Namespace + "Layer");
            XAttribute id = new XAttribute("ID", Id);
            XAttribute partNumber = new XAttribute("PartNumber", PartNumber);
            parentXelement.Add(id);
            parentXelement.Add(partNumber);
            var material = new XElement(Namespace + "Material");
            XAttribute materialType = new XAttribute("Type", MaterialType);
            XAttribute materialGrade = new XAttribute("Grade", MaterialGrade);
            material.Add(materialType);
            material.Add(materialGrade);
            parentXelement.Add(material);
            parentXelement.Add(new XElement(Namespace + "Thickness", Thickness));
            parentXelement.Add(new XElement(Namespace + "IsReference", IsReference));
            return parentXelement;
        }
    }
}
