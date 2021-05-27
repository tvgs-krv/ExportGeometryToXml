using Autodesk.Revit.DB;

namespace XmlExport.Model.FromRevit
{
    public static class PlaneHelper
    {
        public static XYZ ProjectOnto(this Plane plane, XYZ p)
        {
            double d = plane.SignedDistanceTo(p);

            XYZ q = p - d * plane.Normal;

            return q;
        }
        public static double SignedDistanceTo(this Plane plane, XYZ p)
        {
            XYZ v = p - plane.Origin;
            return plane.Normal.DotProduct(v);
        }

    }
}
