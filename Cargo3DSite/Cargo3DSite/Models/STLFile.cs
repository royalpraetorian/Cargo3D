using System.IO;

namespace Cargo3DSite.Models

{
	using GenericStl;
	using System;

	public class STLFile
	{
		public string FileName { get; set; }
		public string STL { get; set; }
		public Guid UserID { get; set; }

		public STLFile()
		{
			
		}
	}
}