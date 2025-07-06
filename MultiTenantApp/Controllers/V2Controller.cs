using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MultiTenantApp.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("v2")]
    public class V2Controller : Controller
    {
        [HttpGet("admin")]
        public IActionResult AdminArea()
        {
            return View("~/Views/V2/Admin.cshtml");
        }
    }
}
