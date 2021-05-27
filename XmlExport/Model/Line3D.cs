using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Autodesk.Revit.DB;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    class Line3D : ILine3D
    {
        public XNamespace Namespace { get; set; }
        public string AttributeName { get; set; }
        public string Value { get; set; }
        public Point3D StartPoint3D { get; set; }
        public Point3D EndPoint3D { get; set; }


        public Line3D(XNamespace ns, Point3D startPoint3D, Point3D endPoint3D)
        {
            Namespace = ns;
            StartPoint3D = startPoint3D;
            EndPoint3D = endPoint3D;
        }

        public XElement CreateStructureXElement()
        {
            var startPoint = new Point3D(Namespace, StartPoint3D.X,StartPoint3D.Y,StartPoint3D.Z, "StartPoint");
            var createStartPoint = startPoint.CreateStructureXElement();
            var endPoint = new Point3D(Namespace, EndPoint3D.X,EndPoint3D.Y,EndPoint3D.Z, "EndPoint");
            var createEndPoint = endPoint.CreateStructureXElement();
            XElement line3dElement = new XElement(Namespace + "Line3d");
            line3dElement.Add(createStartPoint);
            line3dElement.Add(createEndPoint);
            return line3dElement;

        }

    }
}
