using System.Collections.Generic;

namespace XmlExport.Model.Infrastructure
{
    public class RevitMapper
    {
        public string PartNumber { get; set; }
        public List<string> RevitFamilyTypes { get; set; }
        //public string RevitFamilyType { get; set; }
        public string Kks { get; set; }
        public int SmartPlantInsertPoint { get; set; }
        public List<List<string>> Parameters { get; set; }
    }
}
