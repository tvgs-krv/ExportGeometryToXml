using System.Collections.Generic;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Dto
{
    public class DtoBoundaries
    {
        public double Area { get; set; }
        public List<Curve> Curves { get; set; } = new List<Curve>();
        public double NormalX { get; set; }
        public double NormalY { get; set; }
        public double NormalZ { get; set; }
        public double Length { get; set; }

    }
}
