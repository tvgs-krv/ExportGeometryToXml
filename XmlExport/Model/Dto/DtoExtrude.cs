using System.Collections.Generic;
using XmlExport.Model.Abstraction;

namespace XmlExport.Model.Dto
{
    public class DtoExtrude : DtoBaseEntity
    {
        public double BaseOffset { get; set; }
        public double Elevation { get; set; }
        public string PreparedElevation { get; set; }
        public string BuildingName { get; set; }
        public double Thickness { get; set; }
        public List<DtoBoundaries> Boundaries { get; set; }
    }
}
