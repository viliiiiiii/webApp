using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MultiTenantApp.Controllers
{
    [Authorize(Roles = "User")]
    [Route("v1")]
    public class V1Controller : Controller
    {
        [HttpGet("user")]
        public IActionResult UserArea()
        {
            return View("~/Views/V1/User.cshtml");
        }
    }
}
