using Microsoft.AspNetCore.Mvc;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{
    public class HomeController : Controller
    {
        [Area("Dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
