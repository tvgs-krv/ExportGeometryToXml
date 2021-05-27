using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Dto
{
    public class DtoInsertAtPoint : DtoBaseEntity
    {
        public string PartNumber { get; set; }
        public int SmartPlantInsertPoint { get; set; }
        public double OriginX { get; set; }
        public double OriginY { get; set; }
        public double OriginZ { get; set; }
        public double VectorXx { get; set; }
        public double VectorXy { get; set; }
        public double VectorXz { get; set; }
        public double VectorYx { get; set; }
        public double VectorYy { get; set; }
        public double VectorYz { get; set; }

        public List<List<string>> Parameters { get; set; } = new List<List<string>>();

    }
}
