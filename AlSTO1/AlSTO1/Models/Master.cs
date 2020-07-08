using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Master
    {
        public string NAME { get; set; }

        public IEnumerable<Service> Myservices { get; set; } 
        public Master(string NAME_, IEnumerable<Service> service_)
        {
            this.NAME = NAME_;
            this.Myservices = service_;
        }
    }
}