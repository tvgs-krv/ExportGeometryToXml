using System;
using System.Globalization;
using System.Linq;
using Autodesk.Revit.DB;
using XmlExport.Properties;

namespace XmlExport.Model.FromRevit
{
    public static class BaseInfo
    {
        public static string BuildingName(Document document)
        {
            var projetInfo = new FilteredElementCollector(document).OfCategory(BuiltInCategory.OST_ProjectInformation)
                .ToElements().FirstOrDefault();

            var kksBuildCode = GetInstanceParameterFromElement(projetInfo, Resources.NPP_KKS_Building_Code);
            var kksBuildNumbere = GetInstanceParameterFromElement(projetInfo, Resources.NPP_KKS_Building_Number);
            return kksBuildNumbere + kksBuildCode;
        }

        public static string GetKksBuildNumber(Document document)
        {
            var projetInfo = new FilteredElementCollector(document).OfCategory(BuiltInCategory.OST_ProjectInformation)
                .ToElements().FirstOrDefault();

            if (GetInstanceParameterFromElement(projetInfo, Resources.AR_KKS_Build) != null)
            {
                return GetInstanceParameterFromElement(projetInfo, Resources.AR_KKS_Build);
            }
            if(GetInstanceParameterFromElement(projetInfo, Resources.NPP_KKS_Build)!=null)
            {
                return GetInstanceParameterFromElement(projetInfo, Resources.NPP_KKS_Build);
            }

            return null;
        }

        public static string GetInstanceParameterFromElement(Element element, string parameterName)
        {
            try
            {
                if (element != null && parameterName != null)
                {
                    var parameter = element.LookupParameter(parameterName);
                    if (parameter != null)
                    {
                        switch (parameter.StorageType)
                        {
                            case StorageType.Double:
                                return (parameter.AsDouble() * 304.8).ToString();
                            case StorageType.ElementId:
                                return parameter.AsElementId().ToString();
                            case StorageType.Integer:
                                if (!parameter.HasValue)
                                    return String.Empty;
                                else
                                    return parameter.AsInteger().ToString();
                            case StorageType.None:
                                return String.Empty;
                            case StorageType.String:
                                return parameter.AsString();
                        }
                    }

                }

            }
            catch (Exception e)
            {
                return e.ToString();
            }

            return null;
        }

        public static string GetInstanceParameterFromElementAsMeter(Element element, string parameterName)
        {
            if (element != null && parameterName != null)
            {
                var parameter = element.LookupParameter(parameterName);
                if (parameter != null)
                {
                    switch (parameter.StorageType)
                    {
                        case StorageType.Double:
                            return (parameter.AsDouble() * 304.8 / 1000).ToString(CultureInfo.InvariantCulture);
                        case StorageType.ElementId:
                            return parameter.AsElementId().ToString();
                        case StorageType.Integer:
                            if (!parameter.HasValue)
                                return String.Empty;
                            else
                                return parameter.AsInteger().ToString();
                        case StorageType.None:
                            return String.Empty;
                        case StorageType.String:
                            return parameter.AsString();
                    }
                }

            }
            return String.Empty;
        }

        public static string PreparedLevelDescription2(double inputElevation)
        {
            var trunc = Truncate(inputElevation, 0); // откидывает что после запятой не округляя
            if (inputElevation >= -0.99 && inputElevation <= 0.99)
                return "00";

            if (inputElevation <= -1 && inputElevation >= -2.99)
                return "91";
            if (inputElevation <= -3 && inputElevation >= -4.99)
                return "92";
            if (inputElevation <= -5 && inputElevation >= -6.99)
                return "93";
            if (inputElevation <= -7 && inputElevation >= -8.99)
                return "94";
            if (inputElevation <= -9 && inputElevation >= -10.99)
                return "95";
            if (inputElevation <= -11 && inputElevation >= -12.99)
                return "96";
            if (inputElevation <= -13 && inputElevation >= -14.99)
                return "97";
            if (inputElevation <= -15 && inputElevation >= -16.99)
                return "98";
            if (inputElevation <= -17 && inputElevation >= -23.00)
                return "99";

            return trunc.ToString("00");
        }

        public static string PreparedLevelDescription(double inputElevation)
        {
            var trunc = Truncate(inputElevation, 0); // откидывает что после запятой не округляя

            if (inputElevation <= -8.01 && inputElevation >= -100)
                return "01";
            if (inputElevation <= -7.01 && inputElevation >= -8)
                return "02";
            if (inputElevation <= -6.01 && inputElevation >= -7)
                return "03";
            if (inputElevation <= -5.01 && inputElevation >= -6)
                return "04";
            if (inputElevation <= -4.01 && inputElevation >= -5)
                return "05";
            if (inputElevation <= -3.01 && inputElevation >= -4)
                return "06";
            if (inputElevation <= -2.01 && inputElevation >= -3)
                return "07";
            if (inputElevation <= -1.01 && inputElevation >= -2)
                return "08";
            if (inputElevation <= -0.01 && inputElevation >= -1)
                return "09";

            if (inputElevation >= 0 && inputElevation <= 9.99)
                return trunc.ToString("10");

            if (inputElevation >= 10 && inputElevation <= 39.99)
            {
                var tr2 = trunc + 10;
                return tr2.ToString("00");
            }

            if (inputElevation >= 40 && inputElevation <= 59.99)
            {
                var tr2 = trunc / 2;
                var tr3 = Truncate(tr2, 0);
                return "5" + tr3.ToString()[1];
            }

            if (inputElevation >= 60 && inputElevation <= 79.99)
            {
                var tr2 = trunc / 2;
                var tr3 = Truncate(tr2, 0);
                return "6" + tr3.ToString()[1];
            }

            if (inputElevation >= 80 && inputElevation <= 99.99)
            {
                var tr2 = trunc / 2;
                var tr3 = Truncate(tr2, 0);
                return "7" + tr3.ToString()[1];
            }

            if (inputElevation >= 100 && inputElevation <= 119.99)
            {
                var tr2 = trunc / 2;
                var tr3 = Truncate(tr2, 0);
                return "8" + tr3.ToString()[1];
            }
            if (inputElevation >= 120 && inputElevation <= 121.99)
            {
                var tr2 = trunc / 2;
                var tr3 = Truncate(tr2, 0);
                return "9" + tr3.ToString()[1];
            }
            if (inputElevation >= 122 && inputElevation <= 128.99)
                return "91";
            if (inputElevation >= 129 && inputElevation <= 135.99)
                return "92";
            if (inputElevation >= 136 && inputElevation <= 142.99)
                return "93";
            if (inputElevation >= 143 && inputElevation <= 149.99)
                return "94";
            if (inputElevation >= 150 && inputElevation <= 156.99)
                return "95";
            if (inputElevation >= 157 && inputElevation <= 163.99)
                return "96";
            if (inputElevation >= 164 && inputElevation <= 170.99)
                return "97";
            if (inputElevation >= 171 && inputElevation <= 177.99)
                return "98";
            if (inputElevation >= 178 && inputElevation <= 184.99)
                return "99";

            return trunc.ToString("00");
        }

        public static double Truncate(double value, int precision)
        {
            return Math.Truncate(value * Math.Pow(10, precision)) / Math.Pow(10, precision);
        }


    }
}
