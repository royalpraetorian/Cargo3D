using System.IO;

namespace Cargo3DSite.Models

{
	using GenericStl;
    using MongoDB.Bson;
    using System;

	public class STLFile
	{
        public ObjectId _id{ get; set; }
        public string FileName { get; set; }
		public string STL { get; set; }
		public string UserID { get; set; }

		public STLFile(string fileName, string data, string userID)
		{
            FileName = fileName;
            STL = data;
            UserID = userID;
		}
	}
}