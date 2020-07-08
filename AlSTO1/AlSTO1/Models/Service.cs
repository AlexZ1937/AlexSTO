using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Service
    {
        public string ServiceName { get; set; }
        public Master Tmaster { get; set; }

        public Service(string ServiceID_, Master mast_)
        {
            this.Tmaster = mast_;
            this.ServiceName = ServiceID_;
        }
    }
}