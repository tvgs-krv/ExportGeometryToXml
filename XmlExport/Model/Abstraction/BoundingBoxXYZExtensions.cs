using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model.Abstraction
{
    public static class BoundingBoxXyzExtensions
    {
        public static BoundingBoxXYZ Union(this BoundingBoxXYZ boundingBox, BoundingBoxXYZ other)
        {
            return new BoundingBoxXYZ
            {
                Min = new XYZ(
                    Math.Min(boundingBox.Min.X, other.Min.X),
                    Math.Min(boundingBox.Min.Y, other.Min.Y),
                    Math.Min(boundingBox.Min.Z, other.Min.Z)),
                Max = new XYZ(
                    Math.Max(boundingBox.Max.X, other.Max.X),
                    Math.Max(boundingBox.Max.Y, other.Max.Y),
                    Math.Max(boundingBox.Max.Z, other.Max.Z))
            };
        }
    }
}
