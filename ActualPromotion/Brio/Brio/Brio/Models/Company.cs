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
    
    public partial class Company
    {
        public Company()
        {
            this.Articles = new HashSet<Article>();
            this.CompanyWorks = new HashSet<CompanyWork>();
            this.Divisions = new HashSet<Division>();
            this.Documents = new HashSet<Document>();
            this.Feedbacks = new HashSet<Feedback>();
            this.InfoCards = new HashSet<InfoCard>();
            this.News = new HashSet<News>();
            this.PriceLists = new HashSet<PriceList>();
            this.Products = new HashSet<Product>();
            this.Projects = new HashSet<Project>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Postcode { get; set; }
        public Nullable<int> POBox { get; set; }
        public string Phone3 { get; set; }
    
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<CompanyWork> CompanyWorks { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<InfoCard> InfoCards { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
