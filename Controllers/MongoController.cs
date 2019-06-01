using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Web;

namespace Cargo3D.Controllers
{
	public class MongoController
	{
		public static string ConnectionString { get; set; } = "mongodb://dbAdmin:thisisapasswordsubjecttochange1@fairlymanaged.com";
		public static MongoClient Client { get; set; } = new MongoClient(ConnectionString);

	}
}