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
    
    public partial class PropHome
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string Pr_Loan_For { get; set; }
        public Nullable<decimal> Pr_Amount { get; set; }
        public Nullable<int> Pr_Terms { get; set; }
        public string Pr_Loan_Purpose { get; set; }
        public string Pr_Loan_Prod_Categ { get; set; }
        public string Pr_Repay_Mode { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
