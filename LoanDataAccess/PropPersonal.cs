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
    
    public partial class PropPersonal
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public Nullable<decimal> Ppr_Amount { get; set; }
        public Nullable<int> Ppr_Terms { get; set; }
        public Nullable<decimal> Ppr_Proces_Fee { get; set; }
        public Nullable<decimal> Ppr_Roi { get; set; }
        public string Ppr_Repayt_Mode { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
