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
    
    public partial class Personal
    {
        public int ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public string App_Name { get; set; }
        public string App_Fath_Spou_Name { get; set; }
        public string App_Mother_Name { get; set; }
        public string App_Status { get; set; }
        public string App_Pan { get; set; }
        public string App_Doc_Type { get; set; }
        public string App_Doc_No { get; set; }
        public Nullable<System.DateTime> App_Doc_Exp { get; set; }
        public string App_Ckyc_No { get; set; }
        public Nullable<System.DateTime> App_Dob { get; set; }
        public string App_Gender { get; set; }
        public string App_Nationality { get; set; }
        public string App_Religion { get; set; }
        public string App_Category { get; set; }
        public string App_Disability { get; set; }
        public string App_Education { get; set; }
        public string App_Marital_Status { get; set; }
        public Nullable<int> App_Dependants_No { get; set; }
        public string App_Email { get; set; }
        public string App_Off_Email { get; set; }
        public Nullable<long> App_Telephone { get; set; }
        public Nullable<long> App_Mobile { get; set; }
        public string App_Pre_Addr { get; set; }
        public string App_Pre_Landmark { get; set; }
        public Nullable<int> App_Pre_Pin { get; set; }
        public string App_Pre_City { get; set; }
        public string App_Pre_State { get; set; }
        public string App_Per_Addr { get; set; }
        public string App_Per_Landmark { get; set; }
        public Nullable<int> App_Per_Pin { get; set; }
        public string App_Per_City { get; set; }
        public string App_Per_State { get; set; }
    
        public virtual LoginDetail LoginDetail { get; set; }
    }
}
