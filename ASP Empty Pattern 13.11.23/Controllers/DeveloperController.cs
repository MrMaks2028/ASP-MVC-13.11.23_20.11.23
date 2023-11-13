using Microsoft.AspNetCore.Mvc;

namespace ASP_Empty_Pattern_13._11._23.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
