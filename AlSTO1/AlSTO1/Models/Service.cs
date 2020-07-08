using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Service
    {
        public string ServiceName { get; set; }

        public Service(string ServiceID_)
        {
            
            this.ServiceName = ServiceID_;
        }
    }
}