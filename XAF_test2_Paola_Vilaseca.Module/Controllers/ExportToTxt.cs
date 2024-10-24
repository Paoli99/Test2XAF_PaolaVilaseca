using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using XAF_test2_Paola_Vilaseca.Module.BusinessObjects;

namespace PaolaVilaseca_Test2.Module.Controllers
{
    public class ExportToTxtController : ViewController
    {
        public ExportToTxtController()
        {
            SimpleAction exportToTxtAction = new SimpleAction(this, "ExportToTxt", DevExpress.Persistent.Base.PredefinedCategory.View)
            {
                Caption = "Exportar lista de tareas como txt",
                ImageName = "Action_Export_ToText"
            };
            exportToTxtAction.Execute += ExportToTxt_Execute;
        }

        private void ExportToTxt_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            // Crear espacio para obtener todas las tareas desde la base de datos
            var objectSpace = Application.CreateObjectSpace(typeof(CRUDTasks));
            var allTasks = objectSpace.GetObjects<CRUDTasks>().ToList();

            if (allTasks.Any())
            {
                string fileContent = string.Empty;

                foreach (var task in allTasks)
                {
                    fileContent += $"ID: {task.Oid} - Descripción: {task.TaskDescription} - Completada: {task.IsCompleted}\n";
                }

                // Crear el archivo temporal en memoria
                var byteArray = System.Text.Encoding.UTF8.GetBytes(fileContent);
                var stream = new MemoryStream(byteArray);

                // Preparar el archivo para su descarga
                string fileName = "TodasLasTareas.txt";

                // Guardar el archivo en la carpeta temporal y abrirlo automáticamente
                var filePath = Path.Combine(Path.GetTempPath(), fileName);
                File.WriteAllBytes(filePath, byteArray);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });

                // Mostrar un mensaje de confirmación
                Application.ShowViewStrategy.ShowMessage("Todas las tareas han sido exportadas como archivo .txt.");
            }
            else
            {
                // Mostrar un mensaje si no hay tareas para exportar
                Application.ShowViewStrategy.ShowMessage("No hay tareas para exportar.", DevExpress.ExpressApp.InformationType.Info);
            }
        }
    }
}
