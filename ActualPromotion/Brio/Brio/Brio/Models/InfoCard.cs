//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Brio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoCard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string Post { get; set; }
        public Nullable<System.DateTime> GetJobDate { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> DivisionId { get; set; }
        public string AvatarUrl { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
