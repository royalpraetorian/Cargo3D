using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo3DSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Creator()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}