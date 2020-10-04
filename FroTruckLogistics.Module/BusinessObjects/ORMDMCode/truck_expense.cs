using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Validation;

namespace FroTruckLogistics.Module.BO
{
    [DevExpress.Persistent.Base.DefaultClassOptions]
    [DevExpress.Persistent.Base.NavigationItem("Data Entry")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("truck_id")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Truck Expense")]
    [DevExpress.ExpressApp.SystemModule.ListViewAutoFilterRow(true)]
    [DevExpress.ExpressApp.DefaultListViewOptions(true, DevExpress.ExpressApp.NewItemRowPosition.Top)]
    [Appearance("truck_expense_item", TargetItems = "vendor_id;invoice_number", Criteria = "payment_type_id.payment_type_id = 2 Or payment_type_id IS NULL", Enabled = false, Priority = 0, Context = "Any")]
    [RuleObjectExists("truck_expense_invoice_exists", DefaultContexts.Save, @"[truck_expense_id]<>'@truck_expense_id' AND vendor_id = '@vendor_id' AND invoice_number = '@invoice_number'", "Invoice number already exists"
        , CriteriaEvaluationBehavior = CriteriaEvaluationBehavior.BeforeTransaction, InvertResult = true, LooksFor = typeof(truck_expense), SkipNullOrEmptyValues = true)]
    [RuleCriteria("truck_expense_date_less_than_tomorrow", DefaultContexts.Save, "trk_exp_date <= NOW()", "Date should be less or equal Today", SkipNullOrEmptyValues = false)]
    public partial class truck_expense
    {
        public truck_expense(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            trk_exp_date = Core.SqlOp.GetServerDateTime(Session);
        }

        //Audit Trail
        public XPCollection<DevExpress.Persistent.BaseImpl.AuditDataItemPersistent> AuditTrail => DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference.GetAuditTrail(Session, this);

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(truck_id) && truck_id != null)
            {
                location_id = truck_id.location_id;
            }

            if (propertyName == nameof(amount) || propertyName == nameof(vat))
            {
                total_amount = amount + vat;
            }
        }
    }

}
