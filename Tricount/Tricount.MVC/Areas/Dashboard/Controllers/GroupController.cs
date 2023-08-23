using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Contexts;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models;
using Tricount.MVC.Models.DTO_s.Expense;
using Tricount.MVC.Models.DTO_s.Group;
using Tricount.MVC.Models.DTO_s.Payment;

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

        [HttpGet]
        public async Task<IActionResult> GetGroups()
        {
            
            var groups = await groupManager.GetAllInclude(null, g => g.GroupUsers.Where(u => u.User.Id == GetUserId())).Result.ToListAsync();
            return View(groups);
        }

        [HttpGet]
        public async Task<IActionResult> GetCreateGroup()
        {
            GroupCreateDTO createDTO = new();
            GroupDetailViewModel groupDetailView = new GroupDetailViewModel();
            groupDetailView.GroupDTO = createDTO;
            return View(groupDetailView.GroupDTO);
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateGroup(GroupDetailViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Zorunlu Alanları Doldurunuz! (*)");
                return View("_CreateModal", viewModel);
            }
            try
            {

                var group = mapper.Map<Group>(viewModel.GroupDTO);
               // group.GroupUsers.Add(; // Add(await userManager.GetUserAsync(User));
                //return Json(group);
                await groupManager.Create(group);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return PartialView(viewModel.GroupDTO);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUpdateGroup(string id)
        {
            var result = groupManager.GetAll(p => p.Id.ToString() == id).Result;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostUpdateGroup(Group group)
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
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return View(group);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetDeleteGroup(string id)
        {
            var result = groupManager.GetAll(g => g.Id.ToString() == id).Result;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostDeleteGroup(Group group)
        {
            if (!ModelState.IsValid)
            {
                return View(group);
            }
            try
            {
                await groupManager.Delete(group);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return View(group);
            }
        }

        [HttpGet]
        [Route("Dashboard/Group/Detail/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            GroupDetailViewModel viewModel = new();
            var groupDetail = await groupManager.GetAllInclude(g => g.Slug == slug, g => g.GroupUsers).Result.FirstOrDefaultAsync();
            var user = groupDetail.GroupUsers.Where(u => u.User.Id == GetUserId()).FirstOrDefault();
            viewModel.Group = groupDetail;

            if (user == null)
            {
                return Redirect("/Identity/Account/AccessDenied");
            }
            return View(viewModel);
        }

        public string GetUserId()
        {
            var userId = userManager.GetUserId(User).ToString();
            return userId;
        }
    }
}
