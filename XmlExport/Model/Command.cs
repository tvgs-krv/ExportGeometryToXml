using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using XmlExport.View;
using XmlExport.ViewModel;

namespace XmlExport.Model
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class Command : IExternalCommand
    {

        public static MainWindow MainWindow { get; private set; }
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                if (MainWindow == null)
                {
                    string title = commandData.Application.ActiveUIDocument.Document.Title;
                    MainWindowViewModel mvvm = new MainWindowViewModel {ReviService = new RevitService(commandData)};
                    MainWindow = new MainWindow { DataContext = mvvm };
                    MainWindow.Closed += (sender, args) => MainWindow = null;
                    MainWindow.ShowDialog();
                }
                else
                {
                    MainWindow.Activate();
                }
            }
            catch (Exception e)
            {
                TaskDialog mainDialog = new TaskDialog("Error")
                {
                    MainInstruction = "Export failed", MainContent = e.ToString()
                };
                mainDialog.Show();


                return Result.Failed;
            }

            return Result.Succeeded;

        }



    }
}
