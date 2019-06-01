using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cargo3DSite.Models;
using MongoDB.Driver;

namespace Cargo3DSite.Controllers
{
    public class ItemController : Controller
    {

		public string ConnectionString { get; set; } = "mongodb://dbAdmin:thisisapasswordsubjecttochange1@fairlymanaged.com";
		public MongoClient Client { get; set; }
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
                //HttpFileCollectionBase files = Request.Files;
                int s = sub.AllFiles.ContentLength;
            }
            return View("AddItem");
        }

		public void InsertRecord(STLFile file)
		{
			//Connect to MongoDB
			Client = new MongoClient(ConnectionString);
			var DB = Client.GetDatabase("CargoItems");
			var Collection = DB.GetCollection<STLFile>("STLFiles");
			//Insert the file.
			Collection.InsertOne(file);
		}

		public void GetFile(string fileName)
		{

		}
	}
}