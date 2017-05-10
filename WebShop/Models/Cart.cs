using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string status { get; set; }
        public int customerID { get; set; }

        public virtual Customer customer { get; set; }
        public virtual List<Order> orders { get; set; }
    }
}