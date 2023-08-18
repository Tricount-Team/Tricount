using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{

    [Area("Dashboard")]
    public class GroupController : Controller
    {
        private readonly IGroupManager groupManager;
        private readonly UserManager<User> userManager;

        public GroupController(IGroupManager groupManager,UserManager<User> userManager)
        {
            this.groupManager = groupManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var groups = await groupManager.GetAllInclude(null, g => g.Users.Where(u => u.Id == GetUserId())).Result.ToListAsync();
            return View(groups);
        }

        [HttpGet]
        public async Task<IActionResult> GetGroups()
        {
            var groups = await groupManager.GetAllInclude(null, g => g.Users.Where(u => u.Id == GetUserId())).Result.ToListAsync();
            return View(groups);
        }

        [HttpGet]
        public async Task<IActionResult> GetCreateGroup()
        {
            Group group = new();
            return View(group);
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateGroup(Group group)
        {
            if (!ModelState.IsValid)
            {
                return View(group);
            }
            try
            {
                await groupManager.Create(group);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return View(group);
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
        [Route("Dashboard/Detail/{id}")]
        public async Task<IActionResult> Detail(string id)
        {
            var groupDetail = await groupManager.GetAll(g => g.Id.ToString() == id);
            return View(groupDetail);
        }

        public string GetUserId()
        {
            var userId = userManager.GetUserId(User).ToString();
            return userId;
        }
    }
}
