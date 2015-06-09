using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TenderIt.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		public ViewResult RegForm ()
		{
			return View ();
		}
		public ViewResult EnterForm ()
		{
			return View ();
		}
		public ViewResult Tenders ()
		{
			return View ();
		}

    }
}
