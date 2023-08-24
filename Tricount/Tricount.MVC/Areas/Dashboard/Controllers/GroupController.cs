using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
				return View("_Createmodal", model);
            }
			try
			{
				var group = mapper.Map<Group>(model.GroupDTO);
				var user = await userManager.GetUserAsync(User);

				await groupManager.Insert(group);
				await groupManager.Update(group);
				user.Groups.Add(group);
				await userManager.UpdateAsync(user);
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
				return View("_Createmodal", model);

			
			}

			
        }
		[HttpGet]
		public async Task<IActionResult> GetUpdateGroup(string id)
		{
			var result = groupManager.GetAll(p=>p.Id.ToString() == id).Result; 
			return View(result);
		}
		[HttpPost]
		public async Task<IActionResult> GetUpdateGroup(Group group)
		{
			if (!ModelState.IsValid)
			{
				return View(group);
			}
			try
			{
				await groupManager.Update(group);
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"Bir hata ile karşılaşıldı./n hata mesajı: {ex.Message}");
				return View(group);
			}

			


		}
		[HttpGet]
		[Route("Dashboard/Group/Detail/{slug}")]
		public async Task<IActionResult> Detail(string slug)
		{
			GroupDetailViewModel viewmodel = new GroupDetailViewModel();

			var groupDetail = await groupManager.GetAllInclude(g=>g.Slug == slug, g=> g.Users).Result.FirstOrDefaultAsync();
			var user = groupDetail.Users.Where(u=>u.Id == GetUserId()).FirstOrDefault();
			viewmodel.Group = groupDetail;
			
		}
	}
}
