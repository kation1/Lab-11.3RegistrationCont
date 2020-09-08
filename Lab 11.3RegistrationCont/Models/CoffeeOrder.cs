using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_11._3RegistrationCont.Models
{
    public class CoffeeOrder
    {
        public string CoffeeType { get; set; }

        public string Size { get; set; }
        public string Pickup { get; set; }
        public DateTime PickUpTime { get; set; }
        public string CustomerName { get; set; }

    }
}

