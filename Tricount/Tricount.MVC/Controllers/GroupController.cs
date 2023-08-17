using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly BL.Abstract.IGroupManager groupManager;
        private readonly UserManager<User> userManager;

        public GroupController(
            BL.Abstract.IGroupManager groupManager,
            UserManager<User> userManager)
        {
            this.groupManager = groupManager;
            this.userManager = userManager;
        }

        public async Task<string> GetUserId()
        {
            var userId = "";
            if (User.Identity.IsAuthenticated)
            {
                var user = await userManager.GetUserAsync(User);
                if (user != null)
                {
                    userId = user.Id;
                }
            }
            return userId;
        }

        public async Task<IActionResult> Index()
        {
            var result = await groupManager.GetAll(p => p.Id.ToString() == GetUserId().Result.ToString());
            return View(result);
        }
    }
}
