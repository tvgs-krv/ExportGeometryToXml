using System;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;

namespace XmlExport.Model.Dto
{
    public class DtoBaseEntity
    {
        public Element Element { get; set; }
        public string Oid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public XYZ BasePoint { get; set; }
        public double AnglePointRotation { get; set; }


    }
}
