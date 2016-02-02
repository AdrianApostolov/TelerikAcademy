using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETAppWithNorthwind.Controllers
{
    public class CustomersController : Controller
    {
        NORTHWNDEntities dbContext = new NORTHWNDEntities();

        public ActionResult All()
        {
            var customers = dbContext.Customers.ToList();

            return View(customers);
        }

        public ActionResult CustomerDetails(string id)
        {
            var customer = dbContext.Customers
                .FirstOrDefault(c => c.CustomerID == id);

            return View(customer);
        }
    }
}