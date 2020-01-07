using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
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
            ViewBag.Message = "Your contact page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id=0)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 22,
                FirstName = "Tyler",
                LastName = "Lyons",
            };

            return View(dayTimeInstructor);
        }
        
        public ActionResult Insturctors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                },
            };
            return View(instructors);
        }
    }
}