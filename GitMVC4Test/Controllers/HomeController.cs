using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GitMVC4Test.Models;

namespace GitMVC4Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            MvcDb db = new MvcDb();
            UserProfile user =
                db.UserProfiles.Single(d => d.UserName == "dbrown");

            ViewBag.Message += ": " + user.UserName;
            return View();
        }
    }
}
