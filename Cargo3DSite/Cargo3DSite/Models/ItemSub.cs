using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Cargo3DSite.Models
{
    public class ItemSub
    {
        public String ItemName { get; set; }
        public String Description { get; set; }
        public HttpFileCollectionBase AllFiles { get; set; }
    }
}