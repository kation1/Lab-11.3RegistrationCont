using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_11._3RegistrationCont.Models;

namespace Lab_11._3RegistrationCont.Controllers
{
    public class CoffeeController : Controller
    {
        [HttpGet]
        public ActionResult OrderCoffee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Receipt(string coffeeType, string size, string service, DateTime pickUpTime, string name)
        {
            if (service == "delivery")
            {
                pickUpTime = pickUpTime.AddMinutes(15);
                ViewBag.TimeMessage = $"Your expected Delivery time is {@pickUpTime}";
            }
            else
            {
                ViewBag.TimeMessage = $"Your expected Pick Up time is {pickUpTime}";
            }
           

            CoffeeOrder order = new CoffeeOrder() { CoffeeType = coffeeType, Size = size, Pickup = service, PickUpTime = pickUpTime, CustomerName = (string)Session["tempCustomer"]};
            return View(order);
        }
    }
}