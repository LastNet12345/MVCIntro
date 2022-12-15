using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Du är nu i en annan controller!");
            return View();
        }
    }
}
