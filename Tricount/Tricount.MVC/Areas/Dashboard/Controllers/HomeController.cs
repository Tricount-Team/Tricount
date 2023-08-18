using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Runtime.InteropServices;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Contexts;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models;

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
