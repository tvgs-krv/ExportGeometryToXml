using XmlExport.Model;

namespace XmlExport.Abstraction
{
    interface ILine3D : IXmlStructure
    {
        public Point3D StartPoint3D { get; set; }
        public Point3D EndPoint3D { get; set; }

    }
}
