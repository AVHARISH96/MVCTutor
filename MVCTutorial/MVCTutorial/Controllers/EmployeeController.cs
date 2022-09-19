using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
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

        public string Address(int id, int? dept=null)
        {
            return "id= " + id + "dept =" + dept;
        }
    }
}