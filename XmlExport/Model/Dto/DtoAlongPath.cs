using System.Collections.Generic;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;

namespace XmlExport.Model.Dto
{
    public class DtoAlongPath:DtoBaseEntity
    {
        public string Level { get; set; }
        public double Height { get; set; }
        public double TopOffset { get; set; }
        public double BaseOffset { get; set; }
        public double Elevation { get; set; }

        public string PreparedElevation { get; set; }
        public XYZ StartPoint { get; set; }
        public XYZ EndPoint { get; set; }
        public XYZ AlongPoint { get; set; }
        public bool IsArc { get; set; }
        public string BuildingName { get; set; }
        public double Width { get; set; }
        public List<DtoBoundaries> Boundaries { get; set; }

        public int CardinalPoint { get; set; }

    }
}
