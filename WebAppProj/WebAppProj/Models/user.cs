using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class user
    {
        [Key]
        public long id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string phoneNum { get; set; }

        public string password { get; set; }

        public string address { get; set; }
    }
}