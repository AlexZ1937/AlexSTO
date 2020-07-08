using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class CATEGORY
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public CATEGORY(int CategoryID_, string NAME_)
        {
            this.CategoryID = CategoryID_;
            this.CategoryName = NAME_;
        }
    }
}