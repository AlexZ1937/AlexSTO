using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Order
    {
        public Product Myproduct { get; set; }

        public bool StatusBuy { get; set; }

        public Order(Product IDProduct_,bool stat_)
        {
            this.Myproduct = IDProduct_;
            this.StatusBuy = stat_;
        }
    }
}