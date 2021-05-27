using Autodesk.Revit.DB;

namespace XmlExport.Model.Abstraction
{
    interface IDtoEntity
    {
        public Element Element { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }

    }
}
