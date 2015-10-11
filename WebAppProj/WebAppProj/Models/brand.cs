using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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

    public class brandsDb : DbContext
    {
        public DbSet<brand> brands { get; set; }
    }
}