using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tricount.BL.Abstract;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models.DTO_s;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{
	[Area("Dashboard")]
	public class GroupController : Controller
	{
		private readonly IGroupManager groupManager;
		private readonly UserManager<User> userManager;
		private readonly IMapper mapper;

		public GroupController(IGroupManager groupManager, UserManager<User> userManager, IMapper mapper) 
		{
			
			this.groupManager = groupManager;
			this.userManager = userManager;
			this.mapper = mapper;
		}
		public async Task<IActionResult> Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> PostCreateGroup(GroupDetailViewModel model)
		{
            if (!ModelState.IsValid)
            {
				ModelState.AddModelError(string.Empty, "Zorunlu alanları doldurunuz!");
				return View(_createmodel model);
            }
        }
	}
}
