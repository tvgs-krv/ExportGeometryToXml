using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlExport.Abstraction
{
    interface IElementCreate <in T>
    {
        public XElement CreateXmlElement(T dataFromModel);
    }
}
