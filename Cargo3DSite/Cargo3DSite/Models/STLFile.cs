using System.IO;

namespace Cargo3DSite.Controllers
{
	using GenericStl;
    using MongoDB.Bson;
    using System;

	public class STLFile
	{
        public ObjectId _id{ get; set; }
        public string FileName { get; set; }
		public byte[] STL { get; set; }
		public string UserID { get; set; }

		public STLFile(string fileName, byte[] data, string userID)
		{
            FileName = fileName;
            STL = data;
            UserID = userID;
		}
	}
}