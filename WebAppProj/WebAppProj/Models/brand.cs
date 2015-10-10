using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class brand
    {   
        [Key]
        public long id { get; set; }

        public string name { get; set; }

        public string phoneNum { get; set; }

        public string logoPath { get; set; }
    }
}