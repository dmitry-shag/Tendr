using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TenderIt.Models;
using TenderIt.Models.Contexts;

namespace TenderIt.Controllers
{
    public class ProductController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            List<ProductTable> list = new List<ProductTable>();

            using (TenderItContext tenderItContext = new TenderItContext())
            {
                list = tenderItContext.ProductTables.ToList();
            }

            return View(list);
        }

    }
}
