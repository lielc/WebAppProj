using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class product
    {
        [Key]
        public long id { get; set; }

        public string name { get; set; }
        
        // FK
        public long brandId { get; set; }

        public string category { get; set; }

        public string subCategory { get; set; }

        public double price { get; set; }

        public long quantity { get; set; }

        public string color { get; set; }

        public string picPath { get; set; }
    }
}