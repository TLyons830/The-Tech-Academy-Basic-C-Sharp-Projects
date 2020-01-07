using MVCIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Users user = new Users();
            user.Id = 1;
            user.Age = 29;
            user.FName = "Tyler";
            user.LName = "Lyons";
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}