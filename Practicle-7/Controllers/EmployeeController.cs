using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicle_7.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string empPro(int id)
        {
            string pro = string.Empty;
            if (id ==1)
            {
                pro = "Emp id is 1";
            }
            else if (id == 2)
            {
                pro = "Emp id is 2";
            }
            else
            {
                pro = "Record not found";
            }
            return pro;
        }
        public string Address(int id, string dept)
        {
            return "Id = " + id + " <br/>Dept = " + dept;
        }
    }
}