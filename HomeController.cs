using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelEx.Models;

namespace ViewModelEx.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Models.Employee>
            {
                new Employee{ empid=1, empname="yogesh", empsalary=2000},
                new Employee{ empid=2, empname="Ranjit", empsalary=7000},
                new Employee{ empid=3, empname="Bhupendra", empsalary=1000}
            };
            //return View("Index", emp);

            List<EmployeeVM> empvmobj = new List<Models.EmployeeVM>();
            foreach (Employee empobj in emp)
            {
                EmployeeVM vmobj = new Models.EmployeeVM();
                vmobj.empname = empobj.empname;
                vmobj.empsalary = empobj.empsalary;
                if (empobj.empsalary > 2000)
                {
                    vmobj.salarycolor = "red";
                }
                else
                {
                    vmobj.salarycolor = "green";
                }
                empvmobj.Add(vmobj);
            }
             return View("VmView",empvmobj);
        }
    }
}