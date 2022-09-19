using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            return View();
        }

        public string ReturnString()
        {
            return "Harish";
        }
    }
}