﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hrapp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LoginnewEntities1 : DbContext
    {
        public LoginnewEntities1()
            : base("name=LoginnewEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<SaveEmployee> SaveEmployees { get; set; }
    
        public virtual int sp_add(string emp_Type, Nullable<int> emp_ID, string emp_Name, Nullable<long> phone_Number, string emp_Email, string emp_Address, string emp_Qualification, Nullable<int> emp_Expericence, Nullable<System.DateTime> emp_Joining_Date, Nullable<System.DateTime> emp_Contract_Date, Nullable<int> emp_PF_NO)
        {
            var emp_TypeParameter = emp_Type != null ?
                new ObjectParameter("Emp_Type", emp_Type) :
                new ObjectParameter("Emp_Type", typeof(string));
    
            var emp_IDParameter = emp_ID.HasValue ?
                new ObjectParameter("Emp_ID", emp_ID) :
                new ObjectParameter("Emp_ID", typeof(int));
    
            var emp_NameParameter = emp_Name != null ?
                new ObjectParameter("Emp_Name", emp_Name) :
                new ObjectParameter("Emp_Name", typeof(string));
    
            var phone_NumberParameter = phone_Number.HasValue ?
                new ObjectParameter("Phone_Number", phone_Number) :
                new ObjectParameter("Phone_Number", typeof(long));
    
            var emp_EmailParameter = emp_Email != null ?
                new ObjectParameter("Emp_Email", emp_Email) :
                new ObjectParameter("Emp_Email", typeof(string));
    
            var emp_AddressParameter = emp_Address != null ?
                new ObjectParameter("Emp_Address", emp_Address) :
                new ObjectParameter("Emp_Address", typeof(string));
    
            var emp_QualificationParameter = emp_Qualification != null ?
                new ObjectParameter("Emp_Qualification", emp_Qualification) :
                new ObjectParameter("Emp_Qualification", typeof(string));
    
            var emp_ExpericenceParameter = emp_Expericence.HasValue ?
                new ObjectParameter("Emp_Expericence", emp_Expericence) :
                new ObjectParameter("Emp_Expericence", typeof(int));
    
            var emp_Joining_DateParameter = emp_Joining_Date.HasValue ?
                new ObjectParameter("Emp_Joining_Date", emp_Joining_Date) :
                new ObjectParameter("Emp_Joining_Date", typeof(System.DateTime));
    
            var emp_Contract_DateParameter = emp_Contract_Date.HasValue ?
                new ObjectParameter("Emp_Contract_Date", emp_Contract_Date) :
                new ObjectParameter("Emp_Contract_Date", typeof(System.DateTime));
    
            var emp_PF_NOParameter = emp_PF_NO.HasValue ?
                new ObjectParameter("Emp_PF_NO", emp_PF_NO) :
                new ObjectParameter("Emp_PF_NO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add", emp_TypeParameter, emp_IDParameter, emp_NameParameter, phone_NumberParameter, emp_EmailParameter, emp_AddressParameter, emp_QualificationParameter, emp_ExpericenceParameter, emp_Joining_DateParameter, emp_Contract_DateParameter, emp_PF_NOParameter);
        }
    }
}
