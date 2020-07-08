using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }

        public Car(int CarID_, string CARNAME_, string CARTYPE_, string CARCOLOR_)
        {
            this.CarID = CarID_;
            this.CarName = CARNAME_;
            this.CarType = CARTYPE_;
            this.CarColor = CARCOLOR_;
        }
    }
}