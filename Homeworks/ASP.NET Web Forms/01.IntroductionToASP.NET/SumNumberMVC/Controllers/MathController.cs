using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumNumberMVC.Controllers
{
    public class MathController : Controller
    {
        public ActionResult Index(double? firstNumber, double? secondNumber)
        {
            if(firstNumber.HasValue && secondNumber.HasValue)
            {
                var result = firstNumber.Value + secondNumber.Value;

                this.ViewBag.firstNumber = firstNumber.ToString();
                this.ViewBag.secondNumber = secondNumber.ToString();
                this.ViewBag.Sum = result.ToString();

                return View();
            }


            this.ViewBag.Sum = this.ViewBag.firstNumber = this.ViewBag.secondNumber = 0;
            return this.View();
        }
    }
}