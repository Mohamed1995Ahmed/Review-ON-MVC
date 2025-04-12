using System.Diagnostics;
using ABC.FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.FirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ViewResult Show()
        {
            var c1=new ViewResult();
            c1.ViewName = "view1";
            return c1 ;
        }
        public ContentResult Show1()
        {
           
            return Content("Hello World");
        }
        public IActionResult ShowMax(int i)
        {
            if (i % 2 == 0)
            {

                return View("view1");

            }
            else
            {
                var c = new ContentResult();
                c.Content = "Hello World";
                return c;
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
