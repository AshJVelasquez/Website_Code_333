using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Website_Code_333.Models
{
    public class CatProfile
    {
        [Key]
        public int catID { get; set; }

        public string name { get; set; }
        public int age { get; set; }
        public string color { get; set; }
        public string gender { get; set; }
        public string breed { get; set; }

    }
}