using System.Collections.Generic;
using XmlExport.Model.Dto;
using XmlExport.Model.Interfaces;

namespace XmlExport.Model.ToXml
{
    class XmlPenetration : XmlElementStructure<CtEquipment, DtoInsertAtPoint>
    {
        public override void SaveXml(List<CtEquipment> xmlElementList, string savePath)
        {
            CtObjects objects = new CtObjects { CpSmartEquipment = xmlElementList.ToArray() };
            XmlCustomSerializer ser = new XmlCustomSerializer();
            ser.SerializeObject(objects, savePath);
        }

        public override CtEquipment ObjectXmlStructure(DtoInsertAtPoint insertAtPoint)
        {
            var penetrations = new CtEquipment();
            penetrations.Name = insertAtPoint.Name;

            List<CtAttribute> ctAttributes = new List<CtAttribute>();
            foreach (var parameter in insertAtPoint.Parameters)
            {
                var attr = MakeAttribute(parameter[0], parameter[1], parameter[2]);
                ctAttributes.Add(attr);
            }
            penetrations.Attributes = ctAttributes.ToArray();

            penetrations.Origin = CreatePoint3d(insertAtPoint.OriginX, insertAtPoint.OriginY, insertAtPoint.OriginZ, 
                insertAtPoint.BasePoint.X, insertAtPoint.BasePoint.Y, insertAtPoint.BasePoint.Z);
            penetrations.VectorX = CreatePoint3dNormal(insertAtPoint.VectorXx, insertAtPoint.VectorXy, insertAtPoint.VectorXz, 
                insertAtPoint.BasePoint.X, insertAtPoint.BasePoint.Y, insertAtPoint.BasePoint.Z);
            penetrations.VectorY = CreatePoint3dNormal(insertAtPoint.VectorYx, insertAtPoint.VectorYy, insertAtPoint.VectorYz,
                insertAtPoint.BasePoint.X, insertAtPoint.BasePoint.Y, insertAtPoint.BasePoint.Z);

            penetrations.PartNumber = insertAtPoint.PartNumber;

            return penetrations;

        }
    }
}
