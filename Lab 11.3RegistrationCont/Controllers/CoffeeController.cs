using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_11._3RegistrationCont.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: Coffee
        public ActionResult OrderCoffee()
        {
            return View();
        }
    }
}