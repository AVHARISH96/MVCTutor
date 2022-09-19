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
            TempData["mykey"] = "This is My Key";
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.Text = TempData["mykey"];
           // ViewBag.Text = TempData.Peek("mykey");
            //TempData.Keep("mykey");
            return View();
        }

        public string ReturnString()
        {
            return "Harish";
        }
    }
}