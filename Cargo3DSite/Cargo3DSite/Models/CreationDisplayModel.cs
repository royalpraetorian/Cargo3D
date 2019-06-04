
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cargo3DSite.Models
{
    public class CreationDisplayModel
    {

        //image, title, author, description, list of files

        public String ImgUrl { get; set; }
        public String Title { get; set; }
        public String AuthorName { get; set; }
        public String Description { get; set; }
        public STLFile File { get; set; }
    }
}