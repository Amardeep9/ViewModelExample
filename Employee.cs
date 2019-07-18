using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelEx.Models
{
    public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public int empsalary { get; set; }
    }


    public class EmployeeVM
    {
        public string salarycolor { get; set; }
        public string empname { get; set; }
        public int empsalary { get; set; }
    }
}