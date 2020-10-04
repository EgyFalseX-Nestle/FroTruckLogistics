using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FroTruckLogistics.Module.BO
{
    [DevExpress.Persistent.Base.DefaultClassOptions]
    [DevExpress.Persistent.Base.NavigationItem("Data Entry")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("truck_id")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Truck KM")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    [DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    public partial class truck_km
    {
        public truck_km(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);
    }

}
