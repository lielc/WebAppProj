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
        [Key][Column(Order = 0)]
        public long orderNum  { get; set; }

        [Key][Column(Order = 1)]
        public long userId { get; set; }

        [Key][Column(Order = 2)]
        public long productId { get; set; }

        public long quantity { get; set; }
        
        public string status { get; set; }
    }

    public class ordersDb : DbContext
    {
        public DbSet<order> orders { get; set; }
    }
}