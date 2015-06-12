using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TenderIt.Models.Contexts;

namespace TenderIt.Models.Initializers
{
    public class TenderItInitializer : DropCreateDatabaseAlways<TenderItContext>
    {
        protected override void Seed(TenderItContext tenderItContext)
        {
            Category development = new Category() { Name = "Разработка сайтов" };
            Category mowingLawn = new Category() { Name = "Стрижка газона" };
            tenderItContext.Categories.Add(development);
            tenderItContext.Categories.Add(mowingLawn);
            tenderItContext.SaveChanges();

            User user = new User() { Login = "admin", Password = "admin", Email = "ivanov@gmail.com", Phone = "+380954569876", IsBlocked = 0, PasswordCount = 1 };
            tenderItContext.Users.Add(user);
            tenderItContext.SaveChanges();

            UserProfile userProfile = new UserProfile() { Name = "Ivan", Surname = "Ivanov", Email = "ivanov@gmail.com", Communications = "", User = user };
            tenderItContext.UserProfiles.Add(userProfile);
            tenderItContext.SaveChanges();

            Company smaertBussines = new Company() { User = user, FullName = "Smart Bussines", Communications = "", ImageLink = "", Description = "Предоставление услуг разработки", Likes = 1, UnLikes = 0};
            tenderItContext.Companies.Add(smaertBussines);
            tenderItContext.SaveChanges();

            Tender tender = new Tender() { Name = "Разработка сайта", Status = "", MaxPrice = 10, Quantity = 1, ImageLink = "", Category = development, Check = 1, StartDate = DateTime.Now};
            tenderItContext.Tenders.Add(tender);
            tenderItContext.SaveChanges();

            TenderOffer offer = new TenderOffer() { Tender = tender, Company = smaertBussines, Offer = ""};
            tenderItContext.TenderOffers.Add(offer);
            tenderItContext.SaveChanges();

            CompanyFeedback feedback = new CompanyFeedback() { Company = smaertBussines, Comment = "", User = user};
            tenderItContext.CompanyFeedbacks.Add(feedback);
            tenderItContext.SaveChanges();

            CompanyInCategory comInCategoryDev = new CompanyInCategory() { Company = smaertBussines, Category = development};
            CompanyInCategory comInCategoryMowingLawn = new CompanyInCategory() { Company = smaertBussines, Category = mowingLawn };
            tenderItContext.CompanyInCategories.Add(comInCategoryDev);
            tenderItContext.CompanyInCategories.Add(comInCategoryMowingLawn);
            tenderItContext.SaveChanges();

            ProductTable product = new ProductTable() { Name = "Интернет магазин", Category = development, Price = 100, Quantity = 1};
            tenderItContext.ProductTables.Add(product);
            tenderItContext.SaveChanges();


        }
    }
}