using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using XmlExport.Model.Abstraction;
using XmlExport.Model.Dto;
using XmlExport.Model.Interfaces;

namespace XmlExport.Model.ToXml
{
    class XmlColumn : XmlElementStructure<CtSlab, DtoExtrude>
    {
        #region Const temp
        private const int LayerId = 1;
        private const string LayerPartNumber = "B30/F050/W6/D2500-SB";
        private const bool LayerIsReference = true;
        private const string LayerMaterialGrade = "B30/F50/W6/D2500";
        private const string LayerMaterialType = "Тяжелый бетон/Heavy concrete";
        #endregion

        //Test

        public override void SaveXml(List<CtSlab> xmlElementList, string savePath)
        {
            CtObjects objects = new CtObjects { CspsSlabEntity = xmlElementList.ToArray() };
            XmlCustomSerializer ser = new XmlCustomSerializer();
            ser.SerializeObject(objects, savePath);
        }
        public override CtSlab ObjectXmlStructure(DtoExtrude extrude)
        {
            var slab = new CtSlab();
            slab.Name = extrude.Name + "_" + extrude.Element.Id;


            #region parents
            var parent2 = MakeParent(extrude.BuildingName, StSystemType.CpUnitSystem);
            var parent3 = MakeParent(extrude.BuildingName + extrude.PreparedElevation, StSystemType.CpmSystem);
            var parent4 = MakeParent(extrude.BuildingName + extrude.PreparedElevation + "_SC_CL", StSystemType.CpStructuralSystem);

#if DEBUG
            var parent0 = MakeParent("Common", StSystemType.CpAreaSystem);
            CtParent parent1 = MakeParent("Test_1", StSystemType.CpAreaSystem);
            List<CtParent> parents = CreateCtParents(
                parent0,
                parent1,
                parent2,
                parent3,
                parent4);

#else
            CT_Parent parent1 = MakeParent(extrude.BuildingName[0].ToString(), ST_SystemType.CPAreaSystem);
            List<CT_Parent> parents = CreateCtParents
            (
                parent1,
                parent2,
                parent3,
                parent4
            );
#endif
            slab.Parents = parents.ToArray();
            #endregion

            slab.NormalOffset = 10;
            slab.BoundProjDirection = StSlabReferenceDirection.Horizontal;
            slab.ThickeningDirection = StSlabReferenceDirection.Horizontal;

            var structType = new CtStructureType { PartNumber = "Монолитная ЖБ балка/Solid Reinforced Concrete Beam" };
            slab.StructureType = structType;


            CtLayer layer = CreateLayer(LayerId, LayerPartNumber, LayerIsReference, extrude.Thickness,
                LayerMaterialGrade, LayerMaterialType);
            var structComposition = CreateStructureComposition(LayerPartNumber, layer);
            slab.StructureComposition = structComposition;

            slab.Thickness = ToDecimal(extrude.Thickness);
            slab.FacePosition = StFacePosition.Bottom;
            var contour = new CtContour();
            List<object> objects = new List<object>();
            var boundaries = extrude.Boundaries;

            #region outer contour

            if (boundaries.Any())
            {
                var firstBound = boundaries.First();
                foreach (var curve in firstBound.Curves)
                {
                    slab.Normal = CreatePoint3dNormal(firstBound.NormalX, firstBound.NormalY, firstBound.NormalZ);

                    var curvePoint0 = extrude.BasePoint + curve.GetEndPoint(0);
                    var curvePoint1 = extrude.BasePoint + curve.GetEndPoint(1);
                    var elevation = extrude.BasePoint.Z + extrude.Elevation;

                    var floorZ = extrude.Elevation;
                    if (curve.IsCyclic)
                    {

                        if (curve is Arc arc)
                        {
                            var arcAlongPoint = extrude.BasePoint + arc.Evaluate(0.5, true);

                            var startPoint = CreatePoint3d(curvePoint0.X, curvePoint0.Y, curvePoint0.Z);
                            var alongPoint = CreatePoint3d(arcAlongPoint.X, arcAlongPoint.Y, arcAlongPoint.Z);
                            var endPoint = CreatePoint3d(curvePoint1.X, curvePoint1.Y, curvePoint1.Z);
                            var arc3d = CreateArc3d(startPoint, alongPoint, endPoint);
                            objects.Add(arc3d);
                        }
                    }
                    else
                    {

                        var startPoint = CreatePoint3d(curvePoint0.X, curvePoint0.Y, curvePoint0.Z);
                        var endPoint = CreatePoint3d(curvePoint1.X, curvePoint1.Y, curvePoint1.Z);
                        var line3d = CreateLine3d(startPoint, endPoint);
                        objects.Add(line3d);
                    }

                }

            }
            contour.Items = objects.ToArray();
            slab.Contour = contour;
            #endregion

            return slab;

        }
    }
}
