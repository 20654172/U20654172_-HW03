using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U20654172_HW03.Models
{
    public class FileModel
    {
        //code to get and set values withing the files per name
        public string FileName { get; set; }

        public HttpPostedFileBase Files{ get; set; }
    }
}