using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace XmlExport.Model
{
    class RevitService
    {
        private ExternalCommandData _command;

        public ExternalCommandData Command
        {
            get { return _command; }
            set { _command = value; }
        }

        private UIApplication _application;

        public UIApplication Application
        {
            get { return _application; }
            set { _application = value; }
        }
        private UIDocument _uidoc;

        public UIDocument Uidoc
        {
            get { return _uidoc; }
            set { _uidoc = value; }
        }


        private Document _document;

        public Document Document
        {
            get { return _document; }
            set { _document = value; }
        }

        public XYZ XyzBasePoint { get; set; }
        public double BasePointAngle { get; set; }
        public Options Options { get; set; }




        public RevitService(ExternalCommandData commandData)
        {
            _command = commandData;
            _application = _command.Application;
            _uidoc = _application.ActiveUIDocument;
            _document = _uidoc.Document;
            XyzBasePoint = BasePoint();
            BasePointAngle = GetAngle();
            Options = GetOptions();
        }

        private XYZ BasePoint()
        {
            var basePoint = new FilteredElementCollector(_document)
                .OfClass(typeof(BasePoint))
                .Cast<BasePoint>()
                .Where(p => !p.IsShared)
                .ToList()
                .FirstOrDefault();
            
            return basePoint.SharedPosition;

        }

        private double GetAngle()
        {
            var activeLoc = _document.ActiveProjectLocation.GetProjectPosition(new XYZ(0, 0, 0));
            
            return activeLoc.Angle;
        }
        private Options GetOptions() => _application.Application.Create.NewGeometryOptions();
    }
}
