using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class order
    {
        [Key]
        public long orderNum  { get; set; }

        [Key]
        [ForeignKey("product"), Column("productId")]
        public long userId { get; set; }

        [Key]
        [ForeignKey("user"), Column("userId")]
        public long productId { get; set; }

        public long quantity { get; set; }
        
        public string status { get; set; }

        public virtual user user { get; set; }
        public virtual product product { get; set; }
    }

    public class ordersDb : DbContext
    {
        public DbSet<order> orders { get; set; }
    }
}