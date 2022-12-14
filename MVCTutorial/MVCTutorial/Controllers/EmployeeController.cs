using MVCTutorial.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTutorial.Controllers
{
    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
       // GET: Employee
        public string EmployeeProfile(int id)
        {
            if (id == 1)
            {
                return "Profile1";
            }
            else if(id==2)
            {
                return "Profile2";
            }
            else
            {
                return "No Record Found";
            }
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { Id = 1, Name = "Chethan" });
            employeeList.Add(new Employee { Id = 2, Name = "Raja" });
            return View(employeeList);
        }

        [HttpGet]
        public ActionResult ValidateEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("ValidateEmp");
        }


  /*      public JsonResult GetEmployee()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Salary = 323;
            employee.Name = "Mani";
           
        }*/

        public ActionResult AjaxForm()
        {
            return View();
        }

        public JsonResult Countries()
        {
            var countries = new List<string>();
            countries.Add("INdia");
            var json=JsonConvert.SerializeObject(countries);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AjaxForm(Employee employee)
        {
            return View();
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        public JsonResult InsertEmployee(Employee emp)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAjax()
        {
            return View();
        }

        public ActionResult JqueryView()
        {
            return View();
        }
        [HttpGet]
        [Route("~/Get/{id}")]
        public ActionResult GetMyEmployee(int id)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { Id = 1, Name = "Chethan" });
            employeeList.Add(new Employee { Id = 2, Name = "Raja" });
            var myEmployee= employeeList.Where(x=>x.Id == id).FirstOrDefault();
            return View(myEmployee);
        }

        public string Address(int id, int? dept=null)
        {
            return "id= " + id + "dept =" + dept;
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ShowEmployees()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowEmployees(Employee employee)
        {
            Employee employee1 = employee;
            return View();
        }

        public ActionResult ShowEmployee(int id)
        {
            var data = GetEmployee(id);
            return View(data);
        }

        private Employee GetEmployee(int id)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 2, Name = "Sony" });
            employees.Add(new Employee { Id = 5, Name = "Lee" });
            return employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}