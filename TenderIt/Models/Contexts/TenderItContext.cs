using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TenderIt.Models.Contexts
{
    public class TenderItContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyFeedback> CompanyFeedbacks { get; set; }
        public DbSet<CompanyInCategory> CompanyInCategories { get; set; }
        public DbSet<ProductTable> ProductTables { get; set; }
        public DbSet<Tender> Tenders { get; set; }
        public DbSet<TenderOffer> TenderOffers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<User> Users { get; set; }

        public TenderItContext()
            : base("DefaultConnection")
        {
        }
    }
}