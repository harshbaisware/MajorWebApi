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
    
    public partial class Nri
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string Nri_Country_Name { get; set; }
        public Nullable<int> Nri_Country_Code { get; set; }
        public string Nri_Tax_Resid { get; set; }
        public string Nri_Jurid_Resid { get; set; }
        public string Nri_Tin { get; set; }
        public string Nri_Birth_Country { get; set; }
        public string Nri_Birth_City { get; set; }
        public string Nri_Jur_Addr { get; set; }
        public string Nri_City { get; set; }
        public string Nri_State { get; set; }
        public Nullable<int> Nri_Zip_Post_Code { get; set; }
        public Nullable<int> Nri_Iso { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
