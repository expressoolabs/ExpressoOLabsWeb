using Microsoft.AspNetCore.Mvc;

namespace ExpressoOLabs.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        public IActionResult ProductExpressoO()
        {
            ViewBag.Current = "Products";
            return View();
        }

        public IActionResult ProductHireSteer()
        {
            ViewBag.Current = "Products";
            return View();
        }

        public IActionResult ProductMachinoo()
        {
            ViewBag.Current = "Products";
            return View();
        }
    }
}
