using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAF_test2_Paola_Vilaseca.Module.BusinessObjects
{
    [DefaultClassOptions]
    
    public class CRUDTasks : BaseObject
    {
        public CRUDTasks(Session session) : base(session) { }

        private string taskDescription;
        private bool isCompleted;

        // Mostrar el Oid como el ID de la tarea (autogenerado)
        [PersistentAlias("Oid")]
        public string TaskID
        {
            get { return Oid.ToString(); }
        }
        // Descripción de la tarea
        public string TaskDescription
        {
            get => taskDescription;
            set => SetPropertyValue(nameof(TaskDescription), ref taskDescription, value);
        }

        //Estado de la tarea 
        public bool IsCompleted
        {
            get => isCompleted;
            set => SetPropertyValue(nameof(IsCompleted), ref isCompleted, value);
        }
    }
}
