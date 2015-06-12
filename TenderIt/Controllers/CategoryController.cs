using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TenderIt.Models;
using TenderIt.Models.Contexts;

namespace TenderIt.Controllers
{
    public class CategoryController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            List<Category> list = new List<Category>();

            using (TenderItContext tenderItContext = new TenderItContext())
            {
                list = tenderItContext.Categories.ToList();
            }

            return View(list);
        }

    }
}
