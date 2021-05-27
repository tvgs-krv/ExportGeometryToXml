using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Autodesk.Revit.DB;

namespace XmlExport.Model
{
    public class XmlStructure
    {
        public double BuildingPositionX { get; set; }
        public double BuildingPositionY { get; set; }
        public double BuildingPositionZ { get; set; }

        public XDocument CreateDocument(XElement xElement)
        {
            XDocument xdoc = new XDocument();
            XNamespace ns = "urn:S3DIntegration";
            var element = new XElement(ns + "Objects");
            element.Add(xElement);
            xdoc.Add(element);
            return xdoc;
        }

        public XDocument CreateDocument(List<XElement> xElements)
        {
            XDocument xdoc = new XDocument();
            XNamespace ns = "urn:S3DIntegration";
            var element = new XElement(ns + "Objects");
            if (xElements.Any())
            {
                foreach (var xElement in xElements)
                {
                    element.Add(xElement);
                }
            }
            xdoc.Add(element);
            return xdoc;
        }

        public XElement CreateXElement(XNamespace ns, string propertyName, Dictionary<string, string> attributeKeyValuePair)
        {
            if (String.IsNullOrEmpty(propertyName) || !attributeKeyValuePair.Any()) return null;
            XElement xElement = new XElement(ns + propertyName);
            foreach (var properyAttribute in attributeKeyValuePair)
            {
                var attributeKey = properyAttribute.Key;
                var attributeValue = properyAttribute.Value;
                XAttribute attribute = new XAttribute(attributeKey, attributeValue);
                xElement.Add(attribute);
            }
            return xElement;
        }

        public XElement CreateXElement(XNamespace ns, string propertyName, string attributeName, string attributeValue)
        {
            if (!String.IsNullOrEmpty(propertyName) && !String.IsNullOrEmpty(attributeName) && !String.IsNullOrEmpty(attributeValue))
            {
                XElement xElement = new XElement(ns + propertyName, new XAttribute(attributeName, attributeValue));
                return xElement;
            }
            return null;
        }

        public XElement CreateXElement(XNamespace ns, string propertyName, string propertyValue)
        {
            if (!String.IsNullOrEmpty(propertyName) && !String.IsNullOrEmpty(propertyValue))
            {
                XElement xElement = new XElement(ns + propertyName, propertyValue);
                return xElement;
            }
            return null;
        }

        public XElement CreateLine3d(XNamespace ns, XYZ startPoint, XYZ endPoint)
        {
            Dictionary<string, string> startPointDictionary = new Dictionary<string, string>
            {
                ["X"] = startPoint.X.ToString(),
                ["Y"] = startPoint.Y.ToString(),
                ["Z"] = startPoint.Z.ToString()
            };

            Dictionary<string, string> endPointDictionary = new Dictionary<string, string>
            {
                ["X"] = endPoint.X.ToString(),
                ["Y"] = endPoint.Y.ToString(),
                ["Z"] = endPoint.Z.ToString()
            };

            var startPointXElement = CreateXElement(ns, "StartPoint", startPointDictionary);
            var endPointXElement= CreateXElement(ns, "EndPoint", endPointDictionary);
            XElement line3dElement = new XElement(ns+"Line3d");
            line3dElement.Add(startPointXElement);
            line3dElement.Add(endPointXElement);
            return line3dElement;
        }


        
    }
}
