using System.Xml.Linq;

namespace XmlExport.Abstraction
{
    interface IInteractionWithModel
    {
        public XElement GetDataFromModel<T>(T model);
    }
}
