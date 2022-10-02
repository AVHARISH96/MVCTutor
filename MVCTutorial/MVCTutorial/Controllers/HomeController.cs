using MVCTutorial.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    //[HandleError]
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

/*        public ActionResult Error()
        {
            try {
                throw new Exception("This is an Exception");
            }
            catch (Exception ex) {
                return View();
            }
        }*/

  
        public ActionResult ExceptionDemo()
        {
                throw new Exception("This is an Exception");
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

        public JsonResult GetJsonResult()
        {
            Employee emp = new Employee() { Id = 1, Name = "John", Salary = 32 };
            var jsonobj=JsonConvert.SerializeObject(emp);
            return Json(jsonobj,JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult GetDate()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}