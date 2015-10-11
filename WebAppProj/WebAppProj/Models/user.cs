using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class user
    {
        [Key]
        public long userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNum { get; set; }
        [ForeignKey("lecture"), Column("lectureId")]
        public long classId { get; set; }
        public string password { get; set; }
        public virtual lecture lecture { get; set; }
    }
    public class userDb : DbContext
    {
        public DbSet<user> users { get; set; }

        public System.Data.Entity.DbSet<WebAppProj.Models.lecture> lectures { get; set; }
    }
}