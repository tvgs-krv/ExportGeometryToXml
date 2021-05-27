using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Dto
{
    class DtoShiftOpening
    {
        public Element Element { get; set; }
        public double Delta { get; set; }
    }
}
