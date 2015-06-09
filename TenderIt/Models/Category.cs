using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class Category
    {
        public string Name { get; set; }
    }

    public class Company
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Communications { get; set; }
        public Guid UserId { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public int? Likes { get; set; }
        public int? Unlikes { get; set; }
    }

    public class CompanyFeedBack
    {
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
       // public string CompanyId { get; set; } // временно закоментил, у меня ошибку відает при запуске

    }

    public class CompanyInCategories
    {
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
    }

    public class ProductTable
    {
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Tender
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal MaxPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageLink { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Check { get; set; }

    }

    public class TenderOffer
    {
        public Guid TanderId { get; set; }
        public Guid CompanyId { get; set; }
        public string Offer { get; set; }
    }

    public class UserProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Communications { get; set; }
        public Guid UserId { get; set; }

    }

    public class Users
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int isBlocked { get; set; }
        public int PasswordCount { get; set; }

    }


}