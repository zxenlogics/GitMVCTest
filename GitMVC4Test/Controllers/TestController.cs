using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitMVC4Test.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

    }
}
