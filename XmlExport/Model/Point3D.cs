using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Point3D : IPoint3D
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D Point { get; set; }

        public Point3D(XNamespace ns, double x, double y, double z, string name =null)
        {
            Namespace = ns;
            AttributeName = name;
            X = x;
            Y = y;
            Z = z;
        }

        public XElement CreateStructureXElement()
        {
            XElement xElement = new XElement(Namespace + AttributeName);
            XAttribute xAttribute = new XAttribute("X", X);
            XAttribute yAttribute = new XAttribute("Y", Y);
            XAttribute zAttribute = new XAttribute("Z", Z);
            xElement.Add(xAttribute);
            xElement.Add(yAttribute);
            xElement.Add(zAttribute);
            return xElement;
        }
    }
}
