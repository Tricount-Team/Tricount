using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tricount.BL.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{
	public class HomeController : Controller
	{
		private readonly UserManager<User> userManager;
		private readonly IGroupManager groupManager;

		public HomeController(UserManager<User> userManager, IGroupManager groupManager)
		{
			this.userManager = userManager;
			this.groupManager = groupManager;
		}

		public string GetUserId()
		{
			var userId = userManager.GetUserId(User).ToString();
			return userId;
		}

		[Area("Dashboard")]
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
