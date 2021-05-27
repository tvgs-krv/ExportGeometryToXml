#define InsideTest
using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;
using XmlExport.Model.Interfaces;

namespace XmlExport.Model.ToXml
{
    public class XmlWall : XmlElementStructure<CtWall, DtoAlongPath>
    {

        #region Const temp
        private const int LayerId = 1;
        private const string LayerPartNumber = "B30/F050/W6/D2500-WL";
        private const bool LayerIsReference = true;
        private const string LayerMaterialGrade = "B30/F50/W6/D2500_15.74804&quot;";
        private const string LayerMaterialType = "Тяжелый бетон/Heavy concrete";
        private const string CoordinateSystem = "CS_Integration_10UJA";

        #endregion


        public override void SaveXml(List<CtWall> walls, string savePath)
        {
            CtObjects objects = new CtObjects { SpsWallPart = walls.ToArray() };
            XmlCustomSerializer ser = new XmlCustomSerializer();
            ser.SerializeObject(objects, savePath);
        }

        public override CtWall ObjectXmlStructure(DtoAlongPath alongPath)
        {

            var spsWallPart = new CtWall();
            //spsWallPart.OID = alongPath.Oid;
            var eid = new List<string>();
            eid.Add($"Model= {alongPath.Element.Document.Title}; ID = {alongPath.Element.Id}");
            //CT_EIDs eids = new CT_EIDs();
            //eids.EID = eid.ToArray();

            //spsWallPart.EIDs = eid.ToArray();
            spsWallPart.Name = $"{alongPath.Name}_{alongPath.Element.Id}";

            #region parents

            var parent2 = MakeParent(alongPath.BuildingName, StSystemType.CpUnitSystem);
            var parent3 = MakeParent(alongPath.BuildingName + alongPath.PreparedElevation, StSystemType.CpmSystem);
            var parent4 = MakeParent(alongPath.BuildingName + alongPath.PreparedElevation + "_SC_WL", StSystemType.CpStructuralSystem);

#if DEBUG
            var parent0 = MakeParent("Common", StSystemType.CpAreaSystem);
            CtParent parent1 = MakeParent("Test_1", StSystemType.CpAreaSystem);
            List<CtParent>  parents = CreateCtParents
            (
                parent0,
                parent1,
                parent2,
                parent3,
                parent4
                );
            spsWallPart.CoordinateSystem = CoordinateSystem;

#else
            CT_Parent parent1 = MakeParent(alongPath.BuildingName[0].ToString(), ST_SystemType.CPAreaSystem);
            List<CT_Parent> parents = CreateCtParents
            (
                parent1,
                parent2,
                parent3,
                parent4
            );
            spsWallPart.CoordinateSystem = "CS_" + alongPath.BuildingName;
#endif



            spsWallPart.Parents = parents.ToArray();
            #endregion


            //var structType = new CT_StructureType { PartNumber = "Монолитная ЖБ стена/Solid Wall" };
            //spsWallPart.StructureType = structType;

            //CT_Layer layer = CreateLayer
            //(
            //    LayerId,
            //    LayerPartNumber,
            //    LayerIsReference,
            //    alongPath.Width,
            //    LayerMaterialGrade,
            //    LayerMaterialType
            //    );

            //var structComposition = CreateStructureComposition(LayerPartNumber, layer);
            //spsWallPart.StructureComposition = structComposition;

            var crossSection = new CtStructureCrossSection();
            crossSection.ReferenceStandard = "Wall Cross-Sections";
            crossSection.Type = "Rect";
            crossSection.Name = "Rect_3500x0400";
            crossSection.Thickness = ToDecimal(alongPath.Width);
            crossSection.Height = ToDecimal(alongPath.Height);
            crossSection.HorisontalOffset = 0;
            crossSection.HorisontalOffsetSpecified = true;
            crossSection.VerticalOffsetSpecified = true;
            //crossSection.VerticalOffset = ToDecimal(alongPath.BaseOffset);
            crossSection.CardinalPoint = "2";
            spsWallPart.StructureCrossSection = crossSection;

            var path = new CtPath();
            if (alongPath.IsArc)
            {
                List<CtArc3d> arc3ds = new List<CtArc3d>();
                arc3ds.Add(new CtArc3d
                {
                    StartPoint = new CtPoint3d
                    {
                        X = ToDecimal(alongPath.BasePoint.X + alongPath.StartPoint.X),
                        Y = ToDecimal(alongPath.BasePoint.Y + alongPath.StartPoint.Y),
                        Z = ToDecimal(alongPath.BasePoint.Z + alongPath.Elevation + alongPath.BaseOffset)
                    },
                    AlongPoint = new CtPoint3d
                    {
                        X = ToDecimal(alongPath.BasePoint.X + alongPath.AlongPoint.X),
                        Y = ToDecimal(alongPath.BasePoint.Y + alongPath.AlongPoint.Y),
                        Z = ToDecimal(alongPath.BasePoint.Z + alongPath.Elevation + alongPath.BaseOffset)
                    },
                    EndPoint = new CtPoint3d
                    {
                        X = ToDecimal(alongPath.BasePoint.X + alongPath.EndPoint.X),
                        Y = ToDecimal(alongPath.BasePoint.Y + alongPath.EndPoint.Y),
                        Z = ToDecimal(alongPath.BasePoint.Z + alongPath.Elevation + alongPath.BaseOffset)
                    }
                });
                path.Items = arc3ds.ToArray();

            }
            else
            {
                List<CtLine3d> lines = new List<CtLine3d>();
                lines.Add(new CtLine3d
                {
                    StartPoint = new CtPoint3d
                    {
                        X = ToDecimal(alongPath.BasePoint.X + alongPath.StartPoint.X),
                        Y = ToDecimal(alongPath.BasePoint.Y + alongPath.StartPoint.Y),
                        Z = ToDecimal(alongPath.BasePoint.Z + alongPath.Elevation + alongPath.BaseOffset)
                    },
                    EndPoint = new CtPoint3d
                    {
                        X = ToDecimal(alongPath.BasePoint.X + alongPath.EndPoint.X),
                        Y = ToDecimal(alongPath.BasePoint.Y + alongPath.EndPoint.Y),
                        Z = ToDecimal(alongPath.BasePoint.Z + alongPath.Elevation + alongPath.BaseOffset)
                    }

                });
                path.Items = lines.ToArray();

            }
            spsWallPart.Path = path;

            #region Проемы
            var boundaries = alongPath.Boundaries;
            List<CtOpening> openings = new List<CtOpening>();
            if (boundaries.Any())
            {
                int i = 1;
                foreach (var dtoBoundaries in boundaries)
                {
                    if (!dtoBoundaries.Curves.Any())
                    {
                        continue;
                    }
                    List<object> openingObject = new List<object>();
                    CtOpening opening = new CtOpening();
                    //opening.Type = ST_OpeningGeometry.Sketch2d;
                    opening.Name = "Opening-1-654";
                    //opening.OID = Guid.NewGuid().ToString();

                    opening.Direction = new CtPoint3d
                    {
                        X = ToDecimalWithoutConvertUnits(dtoBoundaries.NormalX),
                        Y = ToDecimalWithoutConvertUnits(dtoBoundaries.NormalY),
                        Z = ToDecimalWithoutConvertUnits(dtoBoundaries.NormalZ)
                    };
                    opening.CuttingDepth = ToDecimal(alongPath.Width);
                    var openContour = new CtContour();
                    foreach (var curve in dtoBoundaries.Curves)
                    {
                        if (curve.IsCyclic)
                        {
                            if (curve is Arc arc)
                            {
                                openingObject.Add(new CtArc3d
                                {

                                    StartPoint = new CtPoint3d
                                    {
                                        X = ToDecimal(alongPath.BasePoint.X + curve.GetEndPoint(0).X),
                                        Y = ToDecimal(alongPath.BasePoint.Y + curve.GetEndPoint(0).Y),
                                        Z = ToDecimal(alongPath.BasePoint.Z + curve.GetEndPoint(0).Z)
                                    },
                                    AlongPoint = new CtPoint3d
                                    {

                                        X = ToDecimal(alongPath.BasePoint.X + arc.Evaluate(0.5, true).X),
                                        Y = ToDecimal(alongPath.BasePoint.Y + arc.Evaluate(0.5, true).Y),
                                        Z = ToDecimal(alongPath.BasePoint.Z + arc.Evaluate(0.5, true).Z)
                                    },
                                    EndPoint = new CtPoint3d
                                    {
                                        X = ToDecimal(alongPath.BasePoint.X + curve.GetEndPoint(1).X),
                                        Y = ToDecimal(alongPath.BasePoint.Y + curve.GetEndPoint(1).Y),
                                        Z = ToDecimal(alongPath.BasePoint.Z + curve.GetEndPoint(1).Z)
                                    }
                                });
                            }
                        }
                        else
                        {
                            openingObject.Add(new CtLine3d()
                            {
                                StartPoint = new CtPoint3d
                                {
                                    X = ToDecimal(alongPath.BasePoint.X + curve.GetEndPoint(0).X),
                                    Y = ToDecimal(alongPath.BasePoint.Y + curve.GetEndPoint(0).Y),
                                    Z = ToDecimal(alongPath.BasePoint.Z + curve.GetEndPoint(0).Z)
                                },
                                EndPoint = new CtPoint3d
                                {
                                    X = ToDecimal(alongPath.BasePoint.X + curve.GetEndPoint(1).X),
                                    Y = ToDecimal(alongPath.BasePoint.Y + curve.GetEndPoint(1).Y),
                                    Z = ToDecimal(alongPath.BasePoint.Z + curve.GetEndPoint(1).Z)
                                }

                            });
                        }
                    }
                    openContour.Items = openingObject.ToArray();
                    opening.Contour = openContour;
                    openings.Add(opening);
                }

                spsWallPart.Openings = openings.ToArray();
            }

            #endregion
            return spsWallPart;
        }
    }
}
