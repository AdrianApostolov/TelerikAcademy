using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETAppWithNorthwind.Controllers
{
    public class ProductsController : Controller
    {
        NORTHWNDEntities dbContext = new NORTHWNDEntities();

        public ActionResult ProductsByCategory(int id)
        {
            var product = dbContext.Products
                .Include("Supplier")
                .Where(p => p.CategoryID == id)
                .ToList();

            return View(product);
        }
    }
}