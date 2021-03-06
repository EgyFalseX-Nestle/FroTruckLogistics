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

    public partial class expense_type : XPLiteObject
    {
        int fexpense_type_id;
        [Key(true)]
        [MemberDesignTimeVisibility(false)]
        [DevExpress.Xpo.DisplayName(@"Oid")]
        public int expense_type_id
        {
            get { return fexpense_type_id; }
            set { SetPropertyValue<int>(nameof(expense_type_id), ref fexpense_type_id, value); }
        }
        string fexpense_type_name;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Expense Type")]
        [DevExpress.Persistent.Validation.RuleRequiredField("expense_type_expense_type_name_req", DevExpress.Persistent.Validation.DefaultContexts.Save, "You must enter Expense Type")]
        public string expense_type_name
        {
            get { return fexpense_type_name; }
            set { SetPropertyValue<string>(nameof(expense_type_name), ref fexpense_type_name, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Expense Type Categories")]
        [Association(@"expense_type_categoryReferencesexpense_type")]
        public XPCollection<expense_type_category> expense_type_categorys { get { return GetCollection<expense_type_category>(nameof(expense_type_categorys)); } }
        [DevExpress.Xpo.DisplayName(@"Truck Expenses")]
        [Association(@"truck_expenseReferencesexpense_type")]
        public XPCollection<truck_expense> truck_expenses { get { return GetCollection<truck_expense>(nameof(truck_expenses)); } }
    }

}
