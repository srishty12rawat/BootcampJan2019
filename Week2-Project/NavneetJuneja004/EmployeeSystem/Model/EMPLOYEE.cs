//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE
    {
        public string id { get; set; }
        public string empid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Adress { get; set; }
    
        public virtual SIGNUP SIGNUP { get; set; }
    }
}