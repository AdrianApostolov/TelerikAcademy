using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETAppWithNorthwind.Areas.Administration.Controllers
{
    public class EmployeesController : Controller
    {
        NORTHWNDEntities dbContext = new NORTHWNDEntities();

        public ActionResult EmployeesDetails()
        {
            var employees = dbContext.Employees.Take(10).ToList();

            return View(employees);
        }
    }
}