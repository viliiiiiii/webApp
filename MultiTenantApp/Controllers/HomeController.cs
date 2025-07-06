using Microsoft.AspNetCore.Mvc;

namespace MultiTenantApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var tenant = HttpContext.Items["Tenant"]?.ToString();
            ViewBag.Tenant = tenant;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
