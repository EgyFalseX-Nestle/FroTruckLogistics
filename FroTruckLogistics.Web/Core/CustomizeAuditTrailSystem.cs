using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.AuditTrail;

namespace FroTruckLogistics.Web.Core
{
    public class CustomizeAuditTrailSystem
    {
        public static void Instance_SaveAuditTrailData(object sender, SaveAuditTrailDataEventArgs e)
        {
            List<AuditDataItem> toDelete = new List<AuditDataItem>();
            foreach (var item in e.AuditTrailDataItems)
            {
                //if (item.AuditObject is MainDemo.Module.BusinessObjects.Contact){}
                if (item.OperationType == AuditOperationType.InitialValueAssigned
                    || item.OperationType == AuditOperationType.AddedToCollection
                    || item.OperationType == AuditOperationType.CollectionObjectChanged
                    || item.OperationType == AuditOperationType.RemovedFromCollection)
                    toDelete.Add(item);
            }
            foreach (var item in toDelete)
            {
                e.AuditTrailDataItems.Remove(item);
            }
        }
    }
}
