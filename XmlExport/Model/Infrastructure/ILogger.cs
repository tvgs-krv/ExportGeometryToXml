using Autodesk.Revit.DB;

namespace XmlExport.Model.Infrastructure
{
    interface ILogger
    {
        void WriteLineError(string exception, Element element, string type);
        void WriteLineOperation(string operationName, string id);
    }
}
