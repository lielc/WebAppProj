using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class academyContext : DbContext
    {
        public academyContext() : base("academyContext") { }

        public DbSet<instructor> instructors { get; set; }

        public DbSet<lecture> lectures { get; set; }

        public DbSet<user> users { get; set; }
    }
}