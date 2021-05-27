using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;
using XmlExport.Model.Infrastructure;
using ArgumentException = Autodesk.Revit.Exceptions.ArgumentException;
using ArgumentNullException = Autodesk.Revit.Exceptions.ArgumentNullException;

namespace XmlExport.Model.FromRevit
{
    public class RevitPenetration : BaseGeometry<DtoInsertAtPoint>
    {

        private string CreateProgramPath(string templateName)
        {
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(assemblyFolder, templateName);
        }

        public override List<DtoInsertAtPoint> ToDto(Document document, Options opt, XYZ basePointXyz, double angle)
        {
            var penetrations = new FilteredElementCollector(document, document.ActiveView.Id)
                .OfCategory(BuiltInCategory.OST_GenericModel)
                .WhereElementIsNotElementType()
                .OfType<FamilyInstance>()
                .Where(r => true && r.SuperComponent == null)
                .ToList();
#if DEBUG
            var path = @"C:\ProgramData\Autodesk\Revit\Addins\2020\XmlExport\Mappers\PenetrationsMapper.json";
#else
            var path = CreateProgramPath("Mappers\\PenetrationsMapper.json");
#endif
            var readMapper = new JsonCustomSerializer();
            var mapperPenetration = readMapper.DeserializeJson(path);


            List<DtoInsertAtPoint> dtoPenetrations = new List<DtoInsertAtPoint>();
            if (penetrations.Any())
            {
                string tt = String.Empty;
                foreach (var penetration in penetrations)
                {
                    var matchMapper = FindMatches(mapperPenetration, penetration.Name);
                    if (matchMapper != null)
                    {

                        var locPointFromSubComponent = GetSubFamilyInstances(penetration, document);

                        DtoInsertAtPoint dtoInsertAtPoint = new DtoInsertAtPoint();
                        //var center = GetCenterOfBoundingBox(penetration);
                        //var insertionPoint = LocationPoint0(locPointFromSubComponent, penetration);
                        var loc = penetration.Location as LocationPoint;
                        var point = loc.Point;
                        Element host = penetration.Host; 
                        XYZ insertionPoint = null;
                        if (matchMapper.SmartPlantInsertPoint == 0)
                        {
                            var wall = host as Wall;
                            
                            if (WallDegreeRotation(penetration) == 0 
                                || WallDegreeRotation(penetration) == 90 
                                || WallDegreeRotation(penetration) == 180)
                            {
                                insertionPoint = GetProjectPoint(wall, document, point, ShellLayerType.Exterior);
                            }
                            else
                            {
                                insertionPoint = GetProjectPoint(wall, document, point, ShellLayerType.Interior);
                            }
                        }
                        else if (matchMapper.SmartPlantInsertPoint == 1)
                        {
                            var wall = host as Wall;

                            insertionPoint = GetProjectPoint(wall, document, point, ShellLayerType.Exterior);
                        }
                        else if (matchMapper.SmartPlantInsertPoint == 2)
                        {
                            var floor = host as Floor;
                            TaskDialog.Show("df", floor.Name);
                            insertionPoint = GetProjectPointFloor(floor, opt, point);
                        }
                        else
                        {
                            var wall = host as Wall;
                            insertionPoint = GetProjectPoint(wall, document, point, ShellLayerType.Exterior);
                        }

                        var vX = penetration.HandOrientation;
                        var vY = penetration.FacingOrientation;
                        dtoInsertAtPoint.OriginX = insertionPoint.X;
                        dtoInsertAtPoint.OriginY = insertionPoint.Y;
                        dtoInsertAtPoint.OriginZ = insertionPoint.Z;

                        dtoInsertAtPoint.VectorXx = vX.X;
                        dtoInsertAtPoint.VectorXy = vX.Y;
                        dtoInsertAtPoint.VectorXz = vX.Z;

                        dtoInsertAtPoint.VectorYx = vY.X;
                        dtoInsertAtPoint.VectorYy = vY.Y;
                        dtoInsertAtPoint.VectorYz = vY.Z;

                        dtoInsertAtPoint.PartNumber = matchMapper.PartNumber;

                        dtoInsertAtPoint.BasePoint = basePointXyz;

                        List<List<string>> parameters = new List<List<string>>();

                        foreach (var parameter in matchMapper.Parameters)
                        {
                            if (!parameter[2].Contains("["))
                            {
                                var parFromRevit = BaseInfo.GetInstanceParameterFromElementAsMeter(penetration, parameter[2]);
                                parameters.Add(new List<string>
                                {
                                    parameter[0],
                                    parameter[1],
                                    parFromRevit
                                });

                            }
                            else
                            {
                                Dictionary<string, string> dict = new Dictionary<string, string>();
                                foreach (var param in ParseFormula(parameter[2]))
                                {
                                    var parFromRevit = BaseInfo.GetInstanceParameterFromElementAsMeter(penetration, param);
                                    dict[param] = parFromRevit;
                                }

                                var result = ReplaceInWord(parameter[2], dict)
                                    .Replace("[", "")
                                    .Replace("]", "");

                                try
                                {
                                    var engine = new ExpressionEvaluator();
                                    var calculate = engine.Evaluate(result).ToString().Replace(",", ".");

                                    parameters.Add(new List<string>
                                    {
                                        parameter[0],
                                        parameter[1],
                                        calculate
                                    });

                                }
                                catch
                                {
                                    parameters.Add(new List<string>
                                    {
                                        parameter[0],
                                        parameter[1],
                                        result
                                    });
                                }
                            }
                        }
                        dtoInsertAtPoint.Parameters = parameters;

                        dtoInsertAtPoint.Name = BaseInfo.GetInstanceParameterFromElementAsMeter(penetration, matchMapper.Kks);

                        dtoPenetrations.Add(dtoInsertAtPoint);
                    }

                }

                //TaskDialog.Show("sd", tt);
            }

            return dtoPenetrations;

        }

        private XYZ GetCenterOfBoundingBox(FamilyInstance familyInstance)
        {
            var bb = familyInstance.get_BoundingBox(null);
            var center = (bb.Max + bb.Min) / 2;
            return center;
        }

        private RevitMapper FindMatches(List<RevitMapper> mappers, string revitType)
        {
            return mappers.Where(x => x.RevitFamilyTypes.Contains(revitType)).Select(x => x).FirstOrDefault();
        }

        public static List<string> ParseFormula(string inputString)
        {
            var matches = Regex.Matches(inputString, @"\[(.*?)\]");

            List<string> splitFormula = new List<string>();
            foreach (Match m in matches)
            {
                var text = m.Groups[1].ToString();
                splitFormula.Add(text);
            }

            return splitFormula;
        }
        private string ReplaceInWord(string word, Dictionary<string, string> dictionary)
        {
            var result = word;

            foreach (var item in dictionary)
            {
                result = Regex.Replace(result, item.Key, item.Value, RegexOptions.IgnoreCase);
            }

            return result;
        }

        private List<XYZ> GetSubFamilyInstances(FamilyInstance penetration, Document document)
        {
            var subComponent = penetration.GetSubComponentIds();
            if (subComponent != null && subComponent.Any())
            {
                var getElements = subComponent.Select(x => document.GetElement(x)).ToList();
                List<XYZ> xyzList = new List<XYZ>();
                foreach (var compId in subComponent)
                {
                    var element = document.GetElement(compId) as FamilyInstance;
                    LocationPoint location = element.Location as LocationPoint;
                    var point = location.Point;
                    xyzList.Add(point);
                }

                return xyzList;
            }

            return null;
        }
        private XYZ LocationPoint0(List<XYZ> xyzList, FamilyInstance penetration)
        {
            if (xyzList != null && xyzList.Any())
            {
                var sortedPoints = xyzList
                    .OrderBy(x => x.X)
                    .ThenBy(y => y.Y)
                    .ThenBy(y => y.Z);
                var less90degree = IsLess90Deg(penetration);
                return less90degree ? sortedPoints.First() : sortedPoints.Last();

                //return sortedPoints.Last();
            }
            return GetCenterOfBoundingBox(penetration);
        }

        private bool IsLess90Deg(FamilyInstance penetration)
        {
            if (penetration.Host is Wall wall)
            {
                var deg2 = Math.Round(wall.Orientation.AngleTo(XYZ.BasisX) * 180 / Math.PI);
                var deg3 = deg2 % 180;
                if (deg3 < 90 && deg3 > 0.1)
                {
                    return true;
                }
            }

            return false;
        }

        private double WallDegreeRotation(FamilyInstance penetration)
        {
            if (penetration.Host is Wall wall)
            {
                var deg2 = Math.Round(wall.Orientation.AngleTo(XYZ.BasisX) * 180 / Math.PI);
                var deg3 = deg2 % 180;
                return deg3;
            }

            return 1;
        }

        private XYZ GetProjectPoint(Wall wall, Document document, XYZ point, ShellLayerType wallPlane)
        {
            IList<Reference> sideFaces = HostObjectUtils.GetSideFaces(wall, wallPlane);

            PlanarFace face = document.GetElement(sideFaces[0]).GetGeometryObjectFromReference(sideFaces[0]) as PlanarFace;
            if (face != null)
            {
                var plane = Plane.CreateByNormalAndOrigin(face.FaceNormal, face.Origin);
                var p2 = ProjectInto(plane, point);
                return plane.Origin + p2.U * plane.XVec + p2.V * plane.YVec;
            }

            return null;
        }

        private XYZ GetProjectPointFloor(Floor floor, Options opt, XYZ point)
        {
            GeometryElement geo = floor.get_Geometry(opt);
            foreach (GeometryObject obj in geo)
            {
                Solid solid = obj as Solid;
                if (solid != null)
                {
                    var face = GetFloorPlanarFace(solid);
                    if (face != null)
                    {
                        var plane = Plane.CreateByNormalAndOrigin(face.FaceNormal, face.Origin);
                        var p2 = ProjectInto(plane, point);
                        return plane.Origin + p2.U * plane.XVec + p2.V * plane.YVec;
                    }
                }
            }

            return null;

        }

        private UV ProjectInto(Plane plane, XYZ p)
        {
            XYZ q = ProjectOnto(plane, p);
            XYZ o = plane.Origin;
            XYZ d = q - o;
            double u = d.DotProduct(plane.XVec);
            double v = d.DotProduct(plane.YVec);
            return new UV(u, v);
        }

        private XYZ ProjectOnto(Plane plane, XYZ p)
        {
            double d = SignedDistanceTo(plane, p);
            XYZ q = p - d * plane.Normal;
            return q;
        }
        private double SignedDistanceTo(Plane plane, XYZ p)
        {
            XYZ v = p - plane.Origin;
            return plane.Normal.DotProduct(v);
        }




    }
}
