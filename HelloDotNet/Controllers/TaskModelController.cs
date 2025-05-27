using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloDotNet.Controllers
{
    public class TaskModelController : Controller
    {
        // GET: TaskModel
        public ActionResult Index()
        {
            // select all tasks and pass to view
            return View();
        }

    }
}