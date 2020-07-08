using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Client
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public Cart Mycart { get; set; }
        public decimal Cash { get; set; }

        public Client(string FNAME_, string LNAME_, string PHONE_, string ADRESS_, string STATUS_, Cart IDCart_, decimal CASH_)
        {
           
            this.Fname = FNAME_;
            this.Lname = LNAME_;
            this.Phone = PHONE_;
            this.Adress = ADRESS_;
            this.Status = STATUS_;
            this.Mycart = IDCart_;
            this.Cash = CASH_;
        }
    }
}