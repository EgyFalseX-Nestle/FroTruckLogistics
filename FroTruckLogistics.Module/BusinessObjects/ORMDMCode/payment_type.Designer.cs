﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FroTruckLogistics.Module.BO
{

    public partial class payment_type : XPLiteObject
    {
        int fpayment_type_id;
        [Key(true)]
        [MemberDesignTimeVisibility(false)]
        [DevExpress.Xpo.DisplayName(@"Oid")]
        public int payment_type_id
        {
            get { return fpayment_type_id; }
            set { SetPropertyValue<int>(nameof(payment_type_id), ref fpayment_type_id, value); }
        }
        string fpayment_type_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Payment Type")]
        [DevExpress.Persistent.Validation.RuleRequiredField("payment_type_payment_type_name_req", DevExpress.Persistent.Validation.DefaultContexts.Save, "You must enter Payment Type")]
        public string payment_type_name
        {
            get { return fpayment_type_name; }
            set { SetPropertyValue<string>(nameof(payment_type_name), ref fpayment_type_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Truck Expenses")]
        [Association(@"truck_expenseReferencespayment_type")]
        public XPCollection<truck_expense> truck_expenses { get { return GetCollection<truck_expense>(nameof(truck_expenses)); } }
    }

}