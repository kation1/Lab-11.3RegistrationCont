using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_11._3RegistrationCont.Models
{
    public class WebUser
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }
    }
}