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
        private readonly IInviteManager inviteManager;
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;

        public GroupController(
            IGroupManager groupManager,
            IInviteManager inviteManager,
            UserManager<User> userManager,
            IMapper mapper
            )
        {
            this.groupManager = groupManager;
            this.inviteManager = inviteManager;
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
            var groups = await groupManager.GetAllInclude(null, g => g.Users.Where(u => u.Id == GetUserId())).Result.ToListAsync();
            return View(groups);
        }

        [HttpGet]
        public async Task<IActionResult> GetCreateGroup()
        {
            GroupCreateDTO createDTO = new();
            GroupDetailViewModel groupDetailView = new GroupDetailViewModel();
            groupDetailView.GroupDTO = createDTO;
            return View(groupDetailView);
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateGroup(GroupDetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Zorunlu Alanları Doldurunuz!");
                return View("_CreateModal", model);
            }
            try
            {
                var group = mapper.Map<Group>(model.GroupDTO);
                var user = await userManager.GetUserAsync(User);

                await groupManager.Create(group);
                await groupManager.Update(group);
                user.Groups.Add(group);
                await userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return View("_CreateModal", model);
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
            var result = await groupManager.GetAll(g => g.Id.ToString() == id);
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

            var groupDetail = await groupManager.GetAllInclude(g => g.Slug == slug, g => g.Users).Result.FirstOrDefaultAsync();
            var user = groupDetail.Users.Where(u => u.Id == GetUserId()).FirstOrDefault();
            viewModel.Group = groupDetail;

            if (user == null)
            {
                return Redirect("/Identity/Account/AccessDenied");
            }

            //var invites = inviteManager.GetAll(i => i.UserId.ToString() == GetUserId()).Result.ToList();
            //viewModel.Invites = invites;

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetInvite(string id)
        {
            GroupDetailViewModel model = new();
            try
            {
                model.Invites = await inviteManager.GetAllInclude(i => i.UserId == GetUserId(), i => i.Group).Result.ToListAsync();
                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> DeniedInvite(string inviteId)
        {
            try
            {
                var invite = inviteManager.GetAll(i => i.Id == inviteId).Result.FirstOrDefault();
                invite.IsFinished = true;
                await inviteManager.Update(invite);
                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return RedirectToAction("Index", "Group");
            }

            return View("Index");
        }

       
        public async Task<IActionResult> AcceptInvite(string inviteId)
        {
            try
            {
                var invite = inviteManager.GetAll(i => i.Id == inviteId).Result.FirstOrDefault();
                var group = groupManager.GetAll(i => i.Id == invite.GroupId).Result.FirstOrDefault();
                var user = await userManager.GetUserAsync(User);

                user.Groups.Add(group);
                await userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return RedirectToAction("Index", "Group");
            }

            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateInvite(GroupDetailViewModel model)
        { 
            try
            {
                var user = await userManager.FindByNameAsync(model.Invite.UserName);
                var group = groupManager.GetAll(g => g.Slug == model.Invite.GroupSlug).Result.FirstOrDefault();
                var userInvite = await inviteManager.GetAllInclude(i => i.UserId == GetUserId(), i => i.User).Result.FirstOrDefaultAsync();

                if (user.Id == GetUserId())
                {
                    ModelState.AddModelError("", $"Zaten gruptasınız!");
                }
                if (group != null && user != null)
                {
                    model.Invite.UserId = user.Id;
                    model.Invite.GroupId = group.Id;
                    model.Invite.SenderId = GetUserId();
                    await inviteManager.Create(model.Invite);
                    return RedirectToAction("Index","Group");
                }

                ModelState.AddModelError("", $"Davet gönderilemedi!");
                return View("_InviteModal", model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Bir hata ile karşılaşıldı.\nHata Mesajı: {ex.Message}");
                return View("_InviteModal", model);
            }
        }

        public string GetUserId()
        {
            var userId = userManager.GetUserId(User).ToString();
            return userId;
        }
    }
}
