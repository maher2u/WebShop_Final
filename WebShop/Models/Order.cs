using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }

        public virtual Product product { get; set; }
        public virtual Cart cart { get; set; }
    }
}