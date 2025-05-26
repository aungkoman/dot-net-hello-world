using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloDotNet.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        // GET: /hello/test
        public ActionResult Test()
        {
            return View();
        }

        // GET: /hello/id/{id}
        public ActionResult Id(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}