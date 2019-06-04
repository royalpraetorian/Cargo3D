﻿using Cargo3DSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo3DSite.Controllers
{
    public class HomeController : Controller
    {


        CatalogModel CM = new CatalogModel();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "User")]
        public ActionResult Creator()
        {
            ViewBag.Message = "";

            return View();
        }

    }
}