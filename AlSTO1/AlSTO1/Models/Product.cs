using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Product
    {
        public string ProductsDescription { get; set; }
        public decimal ProductsPrice { get; set; }
        public CATEGORY Mycategory { get; set; }
        public Car MyCar { get; set; }
        public IEnumerable<Good> Mygoods { get; set; }
        public Service Myservice { get; set; }

        public Product (string ProductsDescription_, decimal ProductsPrice_, CATEGORY CategoryID_, Car CarID_, IEnumerable<Good> GoodsID_, Service serv_)
        { 
            this.ProductsDescription = ProductsDescription_;
            this.ProductsPrice = ProductsPrice_;
            this.Mycategory = CategoryID_;
            this.MyCar = CarID_;
            this.Mygoods = GoodsID_;
            this.Myservice = serv_;
        }
    }
}