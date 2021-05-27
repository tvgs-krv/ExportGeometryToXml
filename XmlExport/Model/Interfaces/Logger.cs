using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Interfaces
{
    public class Logger : ILogger
    {
        private string _folderPath;
        public Logger()
        {
            string getdesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            _folderPath = Directory.CreateDirectory(getdesktopPath + @"\Revit_Export").FullName;

        }

        public void WriteLineError(string exception, Element element, string type)
        {
            using (StreamWriter sw = new StreamWriter(_folderPath + "\\Errors_log.txt", true))
            {
                sw.WriteLine($"ERROR\t[{DateTime.Now}]\t[ID = {element.Id}]\t[{type}]\t[{exception}]");
            }
        }

        public void WriteLineOperation(string operationName, string id)
        {
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Operations_log.txt", true))
            {
                sw.WriteLine($"Операция  [{DateTime.Now}]\t[{id}]\t[{operationName}]");
            }
        }

    }
}
