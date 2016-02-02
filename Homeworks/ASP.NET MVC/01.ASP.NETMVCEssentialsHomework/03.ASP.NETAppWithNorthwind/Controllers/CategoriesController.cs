namespace ASP.NETAppWithNorthwind.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class CategoriesController : Controller
    {
        NORTHWNDEntities dbContext = new NORTHWNDEntities();

        public ActionResult All()
        {
            var categories = dbContext.Categories.ToList();

            return View(categories);
        }
    }
}