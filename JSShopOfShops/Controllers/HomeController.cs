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
            
            

            //do validation

            //save info
            
            //redirect
            return View();
        }
        public ActionResult Summary(User user)
        {
            ViewBag.user = user;
            return View();
        }
    }
}