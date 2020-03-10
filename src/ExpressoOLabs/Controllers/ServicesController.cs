using Microsoft.AspNetCore.Mvc;

namespace ExpressoOLabs.Controllers
{
    public class ServicesController : Controller
    {
        // GET: /<controller>/
        public IActionResult DigitalMarkerting()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult SeoServicesinHyderabad()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult SocialmediaManagementCompany()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult PpcManagementServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult DigitalMediaServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult OnlineReputationManagementServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult StaffingSolutions()
        {
            ViewBag.Current = "Services";
            return View();
        }

        public IActionResult WebDesignAndDev()
        {
            ViewBag.Current = "Services";
            return View();
        }
    }
}
