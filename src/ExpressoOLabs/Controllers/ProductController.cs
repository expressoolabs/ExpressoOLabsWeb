using Microsoft.AspNetCore.Mvc;

namespace ExpressoOLabs.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult ProductExpressoO()
        {
            return View();
        }

        public IActionResult ProductHireSteer()
        {
            return View();
        }

        public IActionResult ProductMachinoo()
        {
            return View();
        }
    }
}
