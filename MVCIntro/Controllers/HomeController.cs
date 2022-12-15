using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(/*string name, int salary*/ /*object genericObject*/ TestModel model)
        {

            // Undvik dessa
            // ViewData["Name"] = name;
            // ViewBag.Name = name;
            // TempData["name"] = name;

            var newModel = new TestModel();
            newModel.Name = model.Name;
            newModel.Salary = model.Salary;


            return View(newModel);
        }

        public IActionResult SendToPrivacy()
        {
            return View(nameof(SendToPrivacy));
        }

       


    }
}