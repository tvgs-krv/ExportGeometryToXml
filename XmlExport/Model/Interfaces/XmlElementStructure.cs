using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Autodesk.Revit.DB;
using XmlExport.Model.ToXml;

namespace XmlExport.Model.Interfaces
{
    public abstract class XmlElementStructure<T, TO>
    {
        public abstract void SaveXml(List<T> xmlElementList, string savePath);
        public abstract T ObjectXmlStructure(TO obj);
        public decimal ToDecimal(double sourceDouble)
        {
            var convertToMeter = ConvertUnits(sourceDouble) / 1000;
            return Convert.ToDecimal(convertToMeter);
        }
        public decimal ToDecimalWithoutConvertUnits(double sourceDouble)
        {
            return Convert.ToDecimal(Math.Round(sourceDouble, 6));
        }
        private double ConvertUnits(double dOffsetInches)
        {
            return UnitUtils.Convert(
                dOffsetInches,
                DisplayUnitType.DUT_DECIMAL_FEET,
                DisplayUnitType.DUT_MILLIMETERS);
        }

        public string GetBuildingName(string activeName)
        {
            if (!string.IsNullOrEmpty(activeName))
            {
                Regex regex = new Regex(@"[0-9][0-9][A-Z][A-Z][A-Z]");
                string mc = regex.Matches(activeName).OfType<Match>().ToList().Select(a => a.Value).FirstOrDefault();
                if (mc != null)
                    return mc;
            }
            return null;
        }

        public string GetBuildingLevel(string activeName)
        {
            if (!string.IsNullOrEmpty(activeName))
            {
                Regex regex = new Regex(@"[0-9][0-9][A-Z][A-Z][A-Z][0-9][0-9]");
                string mc = regex.Matches(activeName).OfType<Match>().ToList().Select(a => a.Value).FirstOrDefault();
                if (mc != null)
                    return mc;
            }
            return null;
        }

        public List<CtParent> CreateCtParents(params CtParent[] parent)
        {
            List<CtParent> parents = new List<CtParent>();
            foreach (var t in parent)
            {
                parents.Add(t);
            }
            return parents;
        }



        public CtParent MakeParent(string name, StSystemType systemType)
        {
            return new CtParent
            {
                Name = name,
                SystemType = systemType
            };

        }

        public CtAttribute MakeAttribute(string ctInterface, string ctAttribute, string value)
        {
            return new CtAttribute
            {
                Interface = ctInterface,
                Attribute = ctAttribute,
                Value = value
            };

        }


        public CtAttribute[] CreateAttrubites(params CtAttribute[] attribute)
        {
            List<CtAttribute> ctAttributes = new List<CtAttribute>();
            foreach (var t in attribute)
            {
                ctAttributes.Add(t);
            }
            return ctAttributes.ToArray();
        }

        public CtStructureComposition CreateStructureComposition(string partNumber, CtLayer layer)
        {
            List<CtLayer> layers = new List<CtLayer> { layer };
            return new CtStructureComposition { PartNumber = partNumber, Layer = layers.ToArray() };
        }

        public CtLayer CreateLayer(int id, string partNumber, bool isReference, double thickness, string materialGrade, string materialType)
        {
            return new CtLayer
            {
                Id = id.ToString(),
                PartNumber = partNumber,
                IsReference = isReference,
                Thickness = ToDecimal(thickness),
                Material = new CtMaterial
                {
                    Grade = materialGrade,
                    Type = materialType
                }
            };
        }

        public CtPoint3d CreatePoint3d(double x, double y, double z)
        {
            return new CtPoint3d
            {
                X = ToDecimal(x),
                Y = ToDecimal(y),
                Z = ToDecimal(z)
            };
        }

        public CtPoint3d CreatePoint3d(double x, double y, double z, double basePointX, double basePointY, double basePointZ)
        {
            return new CtPoint3d
            {
                X = ToDecimal(x+ basePointX),
                Y = ToDecimal(y+ basePointY),
                Z = ToDecimal(z+ basePointZ)
            };
        }

        public CtPoint3d CreatePoint3dNormal(double x, double y, double z)
        {
            return new CtPoint3d
            {
                X = ToDecimalWithoutConvertUnits(x),
                Y = ToDecimalWithoutConvertUnits(y),
                Z = ToDecimalWithoutConvertUnits(z)
            };
        }

        public CtPoint3d CreatePoint3dNormal(double x, double y, double z, double basePointX, double basePointY, double basePointZ)
        {
            return new CtPoint3d
            {
                X = ToDecimalWithoutConvertUnits(x),
                Y = ToDecimalWithoutConvertUnits(y),
                Z = ToDecimalWithoutConvertUnits(z)
            };
        }



        public CtArc3d CreateArc3d(CtPoint3d startPoint, CtPoint3d alongPoint, CtPoint3d endPoint)
        {
            return new CtArc3d
            {
                StartPoint = startPoint,
                AlongPoint = alongPoint,
                EndPoint = endPoint
            };
        }

        public CtLine3d CreateLine3d(CtPoint3d startPoint, CtPoint3d endPoint)
        {
            return new CtLine3d()
            {
                StartPoint = startPoint,
                EndPoint = endPoint
            };
        }
    }

}
