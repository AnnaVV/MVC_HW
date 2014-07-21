using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /My/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTest()
        {
            return View();
        }

        public ActionResult DeleteTest()
        {
            return View();
        }
	}
}