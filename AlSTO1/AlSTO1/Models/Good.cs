using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Good
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Good(string Name_,  decimal Price_)
        {
            this.Name = Name_;
            this.Price = Price_;
        }
    }
}