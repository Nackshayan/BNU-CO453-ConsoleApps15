using ConsoleAppProject.App02;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BmiCalculator()
        {
            BmiCalculator calculator = new BmiCalculator();

            return View(calculator);
        }

        [HttpPost]
        public IActionResult BmiCalculator(BmiCalculator bmi)
        {
            bmi.HeightUnit = "Metres";
            bmi.WeightUnit = "Kilograms";
            bmi.Height = bmi.Height / 100;

            bmi.CalculateIndex();
            double index = bmi.Index;

            return RedirectToAction("HealthMessage", new { index });
        }

        public IActionResult HealthMessage()
        {
            return View();
        }

        public IActionResult OutputBmi()
        {
            return View();
        }

        public IActionResult StudentMarks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
