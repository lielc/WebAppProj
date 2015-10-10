using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProj.Models
{
    public class order
    {
        public long userId { get; set; }

        public long productId { get; set; }
        
        public long orderNum { get; set; }

        public long quantity { get; set; }

        public string status { get; set; }
    }
}