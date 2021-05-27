using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Path : IPath
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public List<XElement> Line3DCollection { get; set; }

        public Path(XNamespace ns, List<XElement> line3DCollection)
        {
            Namespace = ns;
            Line3DCollection = line3DCollection;
            AttributeName = "Path";
        }


        public XElement CreateStructureXElement()
        {
            XElement pathXElement = new XElement(Namespace + AttributeName);

            foreach (var line3D in Line3DCollection)
            {
                pathXElement.Add(line3D);
            }
            return pathXElement;
        }

    }
}
