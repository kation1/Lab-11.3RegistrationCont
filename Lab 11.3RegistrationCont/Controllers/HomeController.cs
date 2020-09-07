using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Lab_11._3RegistrationCont.Models;

namespace Lab_11._3RegistrationCont.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void PrepareSignUp()
        {
            ViewBag.Message = "Sign up Here ";
        }

        //public ViewResult ValidatePassword(string password)
        //{
        //    ViewBag.LastNameStatus = "";
        //    int numValidCondiation = 0;

        //    if (password.Length > 20 || password.Length < 3)
        //    {

        //        PrepareSignUp(); 
        //        ViewBag.LastNameStatus += "password must be between 3 and 20 characters. <br />";   
        //    }
        //    if(!password.C)


        //}

        [HttpGet]
        public ActionResult SignUp()
        {
            PrepareSignUp();
            return View();
        }


        [HttpPost]
        public ActionResult SaveAccount(string firstname, string emailaddress,string password,string lastname, string gender)
        {
            
            string emailcheck =   @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
            Regex regex = new Regex(emailcheck, RegexOptions.IgnoreCase);

            if (emailaddress.IndexOf('@') == -1)
            {
                PrepareSignUp();

                ViewBag.Message = "Not a valid email";
                ViewBag.EmailStatusMessage = "Please make sure your email contains an @ symbol <br />";
                return View("SignUp");
            }
            if (!regex.IsMatch(emailaddress))
            {
                PrepareSignUp();
                ViewBag.Message = "Not a valid email";
                ViewBag.EmailStatusMessage = "Email must folow expected format. letter/number/character @ letter/number/characeter . com/au/edu/ca/etc.";
                return View("SignUp");
            }
            if(firstname.Length >20 || firstname.Length<3)
            {

                PrepareSignUp();

                ViewBag.Message = "Not a valid Name";
                ViewBag.FirstNameStatus = "First name must be between 3 and 20 characters.";
                return View("SignUp");
            }
            if (lastname.Length > 20 || lastname.Length < 3)
            {
                PrepareSignUp();

                ViewBag.Message = "Not a valid Name";
                ViewBag.LastNameStatus = "Last name must be between 3 and 20 characters.";
                return View("SignUp");
            }
            if (password.Length > 20 || password.Length < 3)
            {
                ViewBag.Message = "Not a valid Password";
                PrepareSignUp();
                ViewBag.LastNameStatus += "password must be between 3 and 20 characters. <br />";
                return View("SignUP");
            }




            WebUser user = new WebUser() { FirstName = firstname, Email = emailaddress, Password1 = password, LastName = lastname, Gender = gender };
            return View(user);

        }
    }
}