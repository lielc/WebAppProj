
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace WebAppProj.Models
{
    public class instructor
    {
        [Key]
        public long instructorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string internship { get; set; }
        public string pathPic { get; set; }
    }
}