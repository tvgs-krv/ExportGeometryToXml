using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlExport.Model;

namespace XmlExport.Abstraction
{
    interface IPoint3D: IXmlStructure
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D Point { get; set; }

    }
}
