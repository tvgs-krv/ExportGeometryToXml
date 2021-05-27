using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace XmlExport.Model
{
    class WallDataFromRevit
    {
        public void GetWallFromModel(Document document)
        {
            var walls = new FilteredElementCollector(document)
                .OfCategory(BuiltInCategory.OST_Walls)
                .WhereElementIsNotElementType()
                .OfType<Wall>()
                .Where(r => true);
            foreach (Wall wall in walls)
            {
                
            }

        }

    }
}
