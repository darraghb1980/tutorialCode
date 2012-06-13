using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult IsThisAView()
        {
            ViewData["Title"] = "Yeah Yeah Yeah, Chuuu Chuuu";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
