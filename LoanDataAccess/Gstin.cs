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
    
    public partial class Gstin
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string Gst_Reg { get; set; }
        public string Gst_Exem { get; set; }
        public string Gst_Exem_Reason { get; set; }
        public Nullable<System.DateTime> Gst_Exem_date { get; set; }
        public Nullable<System.DateTime> Gst_Reg_Date { get; set; }
        public string Gst_Reg_Type { get; set; }
        public string Gst_Eco_Zone { get; set; }
        public string Gst_default { get; set; }
        public string Gstin_Addr { get; set; }
        public Nullable<int> Gst_Pin { get; set; }
        public string Gst_City { get; set; }
        public string Gst_State { get; set; }
        public string Gst_Country { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
