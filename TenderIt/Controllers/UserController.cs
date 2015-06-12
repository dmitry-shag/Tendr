using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TenderIt.Models;
using TenderIt.Models.Contexts;

namespace TenderIt.Controllers
{
    public class UserController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            List<User> list = new List<User>();

            using (TenderItContext tenderItContext = new TenderItContext())
            {
                list = tenderItContext.Users.ToList();
            }

            return View(list);
        }

    }
}
