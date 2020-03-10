using Microsoft.AspNetCore.Mvc;

namespace ExpressoOLabs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "Home";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Current = "About";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Current = "Contact";
            return View();
        }

        public IActionResult Careers()
        {
            ViewBag.Current = "Careers";
            return View();
        }

        public IActionResult Blog()
        {
            ViewBag.Current = "Blog";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
