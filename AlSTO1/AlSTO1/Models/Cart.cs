using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public IEnumerable<Order> Orders { get; set; }

        public Cart(int CartID_, IEnumerable<Order> ordrs_)
        {
            this.CartID = CartID_;
            this.Orders = ordrs_;
        }
    }
}