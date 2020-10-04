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
    [DevExpress.Persistent.Base.NavigationItem("Code")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("expense_type_name")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Expense Type")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    //[DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    public partial class expense_type
    {
        public expense_type(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);
    }

}
