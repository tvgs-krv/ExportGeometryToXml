using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using Autodesk.Revit.UI;
using XmlExport.Model;
using XmlExport.Model.Dto;
using XmlExport.Model.FromRevit;
using XmlExport.Model.ToXml;

namespace XmlExport.ViewModel
{
    enum Radio
    {
        ByBuilding,
        ByLevel
    }


    class MainWindowViewModel : ModelBase
    {
        internal RevitService ReviService { get; set; }

        public string DeltaX { get; set; }

        public string DeltaY { get; set; }
        public string DeltaZ { get; set; }
        public string Angle { get; set; }

        #region ExportButton

        public ICommand ExportCommand => new RelayCommandWithoutParameter(Export);

        private void Export()
        {
            Double.TryParse(DeltaX, out double doubleDeltaX);
            Double.TryParse(DeltaY, out double doubleDeltaY);
            Double.TryParse(DeltaZ, out double doubleDeltaZ);
            Double.TryParse(Angle, out double doubleAngle);

            var radAngle = doubleAngle * Math.PI/180;

            XYZ basePoint = ReviService.XyzBasePoint;

            //XYZ basePointWithDelta = basePoint;
            XYZ basePointWithDelta = new XYZ(basePoint.X + doubleDeltaX / 304.8, basePoint.Y + doubleDeltaY / 304.8, basePoint.Z + doubleDeltaZ / 304.8);

            string getdesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var revitExportDir = Directory.CreateDirectory(getdesktopPath + @"\Revit_Export").FullName;
            string path = $"{revitExportDir}\\{ReviService.Document.ActiveView.Name}_";
            //string path = $"{revitExportDir}\\{ReviService.Document.Title}_{ReviService.Document.ActiveView.Name}_";

            var assembly = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            RevitPenetration revitPenetration = new RevitPenetration();

            var penetrations =
                revitPenetration.ToDto(ReviService.Document, ReviService.Options, basePointWithDelta, radAngle);
            if (penetrations != null && penetrations.Any())
            {
                XmlPenetration pen = new XmlPenetration();
                List<CtEquipment> ctPen = new List<CtEquipment>();
                foreach (var penetration in penetrations)
                {
                    ctPen.Add(pen.ObjectXmlStructure(penetration));
                }
                pen.SaveXml(ctPen, path + "_Pen.xml");
            }


            RevitWall revitWall = new RevitWall();
            var walls = revitWall.ToDto(ReviService.Document, ReviService.Options, basePointWithDelta, radAngle);
            if (walls != null && walls.Any())
            {
                XmlWall xmlWall = new XmlWall();
                List<CtWall> ctWalls = new List<CtWall>();
                foreach (var wall in walls)
                {
                    ctWalls.Add(xmlWall.ObjectXmlStructure(wall));
                }
                xmlWall.SaveXml(ctWalls, path + "_Walls.xml");
            }
#if DEBUG
            RevitFamilyInstance revitFamilyInstance = new RevitFamilyInstance();
            var wallsAsFamilyInstance = revitFamilyInstance.ToDto(ReviService.Document, ReviService.Options, basePointWithDelta, radAngle);
            if (wallsAsFamilyInstance != null && wallsAsFamilyInstance.Any())
            {
                XmlColumn column = new XmlColumn();
                List<CtSlab> ctFloor = new List<CtSlab>();
                foreach (var wall2 in wallsAsFamilyInstance)
                {
                    ctFloor.Add(column.ObjectXmlStructure(wall2));
                }
                column.SaveXml(ctFloor, path + "_Custom_Walls.xml");
            }
#endif

            RevitFloor revitFloor = new RevitFloor();
            var floors = revitFloor.ToDto(ReviService.Document, ReviService.Options, ReviService.XyzBasePoint, radAngle);
            if (floors != null && floors.Any())
            {
                XmlFloor xmlFloor = new XmlFloor();
                List<CtSlab> ctFloor = new List<CtSlab>();
                foreach (DtoExtrude floor in floors)
                {
                    ctFloor.Add(xmlFloor.ObjectXmlStructure(floor));
                }

                xmlFloor.SaveXml(ctFloor, path + "_Slabs.xml");
            }

            RevitColumn revitColumn = new RevitColumn();
            var columns = revitColumn.ToDto(ReviService.Document, ReviService.Options, basePointWithDelta, radAngle);
            if (columns != null && columns.Any())
            {
                XmlColumn column = new XmlColumn();
                List<CtSlab> ctColumn = new List<CtSlab>();
                foreach (DtoExtrude col in columns)
                {
                    ctColumn.Add(column.ObjectXmlStructure(col));
                }

                column.SaveXml(ctColumn, path + "_Columns.xml");
            }

            RevitFraming revitFrame = new RevitFraming();
            var frames = revitFrame.ToDto(ReviService.Document, ReviService.Options, basePointWithDelta, radAngle);
            if (frames != null && frames.Any())
            {
                XmlColumn frame = new XmlColumn();
                List<CtSlab> ctFrame = new List<CtSlab>();
                foreach (DtoExtrude col in frames)
                {
                    ctFrame.Add(frame.ObjectXmlStructure(col));
                }

                frame.SaveXml(ctFrame, path + "_StructuralFramings.xml");
            }

        }

        public XDocument CreateDocument(XElement xElement)
        {
            XDocument xdoc = new XDocument();
            XNamespace ns = "urn:S3DIntegration";
            var element = new XElement(ns + "Objects");
            element.Add(xElement);
            xdoc.Add(element);
            return xdoc;
        }


#endregion


#region CheckBoxes

        private bool _isExportRooms;
        public bool IsExportRooms
        {
            get => _isExportRooms;
            set
            {
                _isExportRooms = value;
                OnPropertyChanged(nameof(IsExportRooms));
            }
        }

        private bool _isExportWalls;
        public bool IsExportWalls
        {
            get => _isExportWalls;
            set
            {
                _isExportWalls = value;
                OnPropertyChanged(nameof(IsExportWalls));
            }
        }

        private bool _isExportOpenings;
        public bool IsExportOpenings
        {
            get => _isExportOpenings;
            set
            {
                _isExportOpenings = value;
                OnPropertyChanged(nameof(IsExportOpenings));
            }
        }

        private bool _isExportCeilings;
        public bool IsExportCeilings
        {
            get => _isExportCeilings;
            set
            {
                _isExportCeilings = value;
                OnPropertyChanged(nameof(IsExportCeilings));
            }
        }

        private bool _isExportFloors;
        public bool IsExportFloors
        {
            get => _isExportFloors;
            set
            {
                _isExportFloors = value;
                OnPropertyChanged(nameof(IsExportFloors));
            }
        }




#endregion



#region RadioButtons
        private Radio _defaultRadio = Radio.ByBuilding;
        private string _deltaX;

        public Radio Radio
        {
            get { return _defaultRadio; }
            set
            {
                if (_defaultRadio == value)
                    return;

                _defaultRadio = value;
                OnPropertyChanged("ByBuilding");
                OnPropertyChanged("ByLevel");
            }
        }
        public bool IsByBuilding
        {
            get => Radio == Radio.ByBuilding;
            set => Radio = value ? Radio.ByBuilding : Radio;
        }
        public bool IsByLevel
        {
            get => Radio == Radio.ByLevel;
            set => Radio = value ? Radio.ByLevel : Radio;
        }
#endregion

    }
}
