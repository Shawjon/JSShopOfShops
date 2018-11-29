using JSShopOfShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSShopOfShops.Controllers
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
        public ActionResult Registration()
        {
            ViewBag.Message = "The Registration Page.";

            return View("RegisterUser");
        }
   
        public ActionResult RegisterUser()
        {

            return View();
        }

        public ActionResult Summary()
        {
    
            return View();
        }
        [HttpPost]
        public ActionResult Summary(User user)
        {
            if ((user.Password != user.ConfirmPassword) && (user.Age < 1 || user.Age > 115))
            {
                ViewBag.ErrorMessage = "Passwords do not match and Age is invalid";
            }
            else if (user.Password != user.ConfirmPassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match";
            }
            else if (user.Age < 1 || user.Age >115)
            {
                ViewBag.ErrorMessage = "Age is invalid";
            }
            else
            {
                ViewBag.user = user;
            }
            
            return View(user);
        }
    }
}