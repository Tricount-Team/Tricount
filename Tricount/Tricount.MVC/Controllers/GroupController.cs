using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.AspNetCore.SignalR;
=======
>>>>>>> Test
using Tricount.BL.Abstract;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Controllers
{
    public class GroupController : Controller
    {
<<<<<<< HEAD
        private readonly BL.Abstract.IGroupManager groupManager;
        private readonly UserManager<User> userManager;

        public GroupController(
            BL.Abstract.IGroupManager groupManager,
=======
        private readonly IGroupManager groupManager;
        private readonly IExpenseRepository expenseRepository;
        private readonly IExpenseDetailRepository expenseDetailRepository;
        private readonly IPaymentRepository paymentRepository;
        private readonly UserManager<User> userManager;

        public GroupController(
            IGroupManager groupManager, 
>>>>>>> Test
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
<<<<<<< HEAD
            var result = await groupManager.GetAll(p => p.Id.ToString() == GetUserId().Result.ToString());
=======
     
            var result = await groupManager.GetAll(p => p.CreatedId.ToString() == GetUserId().Result.ToString());
>>>>>>> Test
            return View(result);
        }
    }
}
