using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ViewResult Index()
        {
            ViewBag.Title = "The shop";
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }

        public string Product()
        {
            int id = 100;
            return "Product: Id = " + id.ToString(); 
        }

        public RedirectResult DVD()
        {
            return RedirectPermanent("~/Shop/Product");
        }

    }
}