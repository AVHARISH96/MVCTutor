using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyProperty = "Hello";
            ViewBag.MyList = new List<string>() { "Harish", "Chethan" };
            ViewData["MyList"] = new List<string>() { "Harish", "Chethan" };
            ViewData["Key"] = "Value";
            return View();
        }

        [HttpGet]
        public ActionResult PostUsingParameters()
        {
            return View();
        }

        [HttpPost]
        public string PostUsingParameters (string firstName,string lastName)
        {
            
            return "FirstName"+firstName +" LastName"+lastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            var firstName = Request["firstName"];
            var lastName = Request["lastName"];
            return "FirstName" + firstName + " LastName" + lastName;
        }

        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            var firstName = form["firstName"];
            var lastName = form["lastName"];
            return "FirstName" + firstName + " LastName" + lastName;
        }

        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
            return "Employee ID" + emp.Id + " Name" + emp.Name;
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}