using Microsoft.AspNetCore.Mvc;

namespace ExpressoOLabs.Controllers
{
    public class ServicesController : Controller
    {
        /// <summary>
        /// Digitals the markerting.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult DigitalMarkerting()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Seoes the servicesin hyderabad.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult SeoServicesinHyderabad()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Socialmedias the management company.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult SocialmediaManagementCompany()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// PPCs the management services.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult PpcManagementServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Digitals the media services.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult DigitalMediaServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Called when [reputation management services].
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult OnlineReputationManagementServices()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Staffings the solutions.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult StaffingSolutions()
        {
            ViewBag.Current = "Services";
            return View();
        }

        /// <summary>
        /// Webs the design and dev.
        /// </summary>
        /// <returns>returns result</returns>
        public IActionResult WebDesignAndDev()
        {
            ViewBag.Current = "Services";
            return View();
        }
    }
}
