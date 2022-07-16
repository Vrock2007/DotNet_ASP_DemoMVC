using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Vrock";


            // viewbag is dynamic collection of objects
            ViewBag.Name = name;
            ViewData["Age"] = 30;
            TempData["Name"] = name;
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Name = TempData["Name"];
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
