using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebAppProj.Models
{
    public class lecture
    {
        [Key]
        public long lectureId { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        [ForeignKey("instructor"), Column("instructorId")]
        public long instructorId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public virtual instructor instructor { get; set; }
    }
    public class lectureDb : DbContext
    {
        public DbSet<lecture> lectures { get; set; }

        public System.Data.Entity.DbSet<WebAppProj.Models.instructor> instructors { get; set; }
    }
}