//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Financial
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string Fin_Status { get; set; }
        public Nullable<decimal> Fin_Inc_Gross { get; set; }
        public Nullable<decimal> Fin_Inc_Net { get; set; }
        public Nullable<decimal> Fin_Inc_Othr { get; set; }
        public Nullable<decimal> Fin_Inc_Total { get; set; }
        public string Fin_Bank1_Name { get; set; }
        public string Fin_Bank1_Branch { get; set; }
        public string Fin_Bank1_Ac_Type { get; set; }
        public string Fin_Bank1_Ac_No { get; set; }
        public string Fin_Bank2_Name { get; set; }
        public string Fin_Bank2_Branch { get; set; }
        public string Fin_Bank2_Ac_Type { get; set; }
        public string Fin_Bank2_Ac_No { get; set; }
        public string Fin_Loan1_Bank { get; set; }
        public string Fin_Loan1_Type { get; set; }
        public Nullable<decimal> Fin_Loan1_Amount { get; set; }
        public Nullable<decimal> Fin_Deposits_Inv { get; set; }
        public Nullable<decimal> Fin_Shares_Inv { get; set; }
        public Nullable<decimal> Fin_Insurance_Inv { get; set; }
        public Nullable<decimal> Fin_Mutual_Funds_Inv { get; set; }
        public Nullable<decimal> Fin_Others_Inv { get; set; }
        public Nullable<decimal> Fin_Total_Inv { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
