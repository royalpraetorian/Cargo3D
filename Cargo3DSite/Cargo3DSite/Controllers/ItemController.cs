using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cargo3DSite.Models;

namespace Cargo3DSite.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddItem()
        {
            ViewBag.Message = "Adding an item.";

            return View();
        }

        [HttpPost]
        public ActionResult Upload([Bind(Include = "ItemName,Description,AllFiles")] ItemSub sub)
        {
            if (ModelState.IsValid)
            {
                HttpFileCollectionBase files = Request.Files;
            }
            return View("AddItem");
        }
    }
}