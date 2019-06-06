using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        public ActionResult ItemPage(STLFile temp)
        {
            return View(temp);
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
                //Construct the STLFile object from submited data
                string fileName = sub.AllFiles.FileName;
                byte[] data;
                //Grab data from stream
                var inputStream = sub.AllFiles.InputStream;
                data = Encoding.ASCII.GetBytes(new StreamReader(inputStream).ReadToEnd());
                STLFile item = new STLFile(fileName, data, User.Identity.Name);
                InsertRecord(item);
            }
            return View("AddItem");
        }

        public ActionResult DownloadItem(string fileName)
        {
            STLFile returner = GetFile(fileName);
            return RedirectToAction("ItemPage");
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

        public STLFile GetFile(string fileName)
        {
            Client = new MongoClient(ConnectionString);
            var DB = Client.GetDatabase("CargoItems");
            var Collection = DB.GetCollection<STLFile>("STLFiles");
            STLFile file = Collection.Find(x => x.FileName == fileName).FirstOrDefault();
            //Test

            FileStream testFile = new FileStream("C:\\Fun\\CargoTest.stl", FileMode.Create);
            foreach (byte b in file.STL)
            {
                testFile.WriteByte(b);
                testFile.Seek(0, SeekOrigin.Current);
            }


            return file;
        }
        public string[] GetCatalog()
        {
            Client = new MongoClient(ConnectionString);
            var DB = Client.GetDatabase("CargoItems");
            var Collection = DB.GetCollection<STLFile>("STLFiles");
            return Collection.AsQueryable().Select(x => x.FileName).ToArray();
        }
    }
}