using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Interfaces
{
    interface ILogger
    {
        void WriteLineError(string exception, Element element, string type);
        void WriteLineOperation(string operationName, string id);
    }
}
