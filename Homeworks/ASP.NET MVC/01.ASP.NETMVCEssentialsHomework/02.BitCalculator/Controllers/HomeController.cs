using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitCalculator.ViewModels;

namespace BitCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int quantity = 1, string type = "Bit", int kilo = 1024)
        {
            ViewBag.SelectedType = type;
            ViewBag.SelectedKilo = kilo;
            ViewBag.Quantity = quantity;
            double baseValue = this.BaseValue(kilo, type);
            var units = this.GetValues(kilo, quantity, baseValue);
            return View(units);
        }

        [NonAction]
        private List<EntityViewModel> GetValues(int baseValue, int quantity, double typeBase)
        {
            var listOfUnits = new List<EntityViewModel>()
            {
                new EntityViewModel(){ Name = "Bit", Value = quantity / (Math.Pow(baseValue, 0)/typeBase) * 8},
                new EntityViewModel(){ Name = "Byte", Value = quantity / (Math.Pow(baseValue, 0)/typeBase)},
                new EntityViewModel(){ Name = "Kilobit", Value = quantity / (Math.Pow(baseValue, 1)/typeBase) * 8},
                new EntityViewModel(){ Name = "Kilobyte", Value = quantity / (Math.Pow(baseValue, 1)/typeBase)},
                new EntityViewModel(){ Name = "Megabit", Value = quantity / (Math.Pow(baseValue, 2)/typeBase) * 8},
                new EntityViewModel(){ Name = "Megabyte", Value = quantity / (Math.Pow(baseValue, 2)/typeBase)},
                new EntityViewModel(){ Name = "Gigabit", Value = quantity / (Math.Pow(baseValue, 3)/typeBase) * 8},
                new EntityViewModel(){ Name = "Gigabyte", Value = quantity / (Math.Pow(baseValue, 3)/typeBase)},
                new EntityViewModel(){ Name = "Terabit", Value = quantity / (Math.Pow(baseValue, 4)/typeBase) * 8},
                new EntityViewModel(){ Name = "Terabyte", Value = quantity / (Math.Pow(baseValue, 4)/typeBase)},
                new EntityViewModel(){ Name = "Petabit", Value =  quantity / (Math.Pow(baseValue, 5)/typeBase) * 8},
                new EntityViewModel(){ Name = "Petabyte", Value = quantity / (Math.Pow(baseValue, 5)/typeBase)},
                new EntityViewModel(){ Name = "Exabit", Value = quantity / (Math.Pow(baseValue, 6)/typeBase) * 8},
                new EntityViewModel(){ Name = "Exabyte", Value = quantity / (Math.Pow(baseValue, 6)/typeBase)},
                new EntityViewModel(){ Name = "Zettabit", Value = quantity / (Math.Pow(baseValue, 7)/typeBase) * 8},
                new EntityViewModel(){ Name = "Zettabyte", Value = quantity / (Math.Pow(baseValue, 7)/typeBase)},
                new EntityViewModel(){ Name = "Yottabit", Value = quantity / (Math.Pow(baseValue, 8)/typeBase) * 8},
                new EntityViewModel(){ Name = "Yottabyte", Value = quantity / (Math.Pow(baseValue, 8)/typeBase)},
            };

            return listOfUnits;
        }

        [NonAction]
        private double BaseValue(int baseValue, string typeOfUnit)
        {
            var listOfEntities = new List<EntityViewModel>()
            {
                new EntityViewModel(){ Name = "Bit", Value = (Math.Pow(baseValue, 0)/8)},
                new EntityViewModel(){ Name = "Byte", Value =  (Math.Pow(baseValue, 0))},
                new EntityViewModel(){ Name = "Kilobit", Value =  (Math.Pow(baseValue, 1)/8)},
                new EntityViewModel(){ Name = "Kilobyte", Value = (Math.Pow(baseValue, 1))},
                new EntityViewModel(){ Name = "Megabit", Value = (Math.Pow(baseValue, 2)/8)},
                new EntityViewModel(){ Name = "Megabyte", Value = (Math.Pow(baseValue, 2))},
                new EntityViewModel(){ Name = "Gigabit", Value = (Math.Pow(baseValue, 3)/8)},
                new EntityViewModel(){ Name = "Gigabyte", Value = (Math.Pow(baseValue, 3))},
                new EntityViewModel(){ Name = "Terabit", Value = (Math.Pow(baseValue, 4)/8)},
                new EntityViewModel(){ Name = "Terabyte", Value = (Math.Pow(baseValue, 4))},
                new EntityViewModel(){ Name = "Petabit", Value =  (Math.Pow(baseValue, 5)/8)},
                new EntityViewModel(){ Name = "Petabyte", Value = (Math.Pow(baseValue, 5))},
                new EntityViewModel(){ Name = "Exabit", Value = (Math.Pow(baseValue, 6)/8)},
                new EntityViewModel(){ Name = "Exabyte", Value = (Math.Pow(baseValue, 6))},
                new EntityViewModel(){ Name = "Zettabit", Value = (Math.Pow(baseValue, 7)/8)},
                new EntityViewModel(){ Name = "Zettabyte", Value = (Math.Pow(baseValue, 7))},
                new EntityViewModel(){ Name = "Yottabit", Value = (Math.Pow(baseValue, 8)/8)},
                new EntityViewModel(){ Name = "Yottabyte", Value = (Math.Pow(baseValue, 8))},
            };

            double value = listOfEntities.FirstOrDefault(u => u.Name == typeOfUnit).Value;
            return value;
        }
    }
}