using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using XmlExport.Abstraction;

namespace XmlExport.Model
{
    public class DTOFloor : BaseEntity
    {
        public double BaseOffset { get; set; }
        public double Elevation { get; set; }
        public string BuildingName { get; set; }
        public double Thickness { get; set; }
        public List<DtoBoundaries> Boundaries { get; set; }
    }
}
