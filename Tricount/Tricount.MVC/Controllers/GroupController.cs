using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using Tricount.Entities.Concrete;

namespace Tricount.MVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupRepository groupRepository;
        private readonly IExpenseRepository expenseRepository;
        private readonly IExpenseDetailRepository expenseDetailRepository;
        private readonly IPaymentRepository paymentRepository;
        private readonly UserManager<User> userManager;

        public GroupController(
            IGroupRepository groupRepository, 
            IExpenseRepository expenseRepository,
            IExpenseDetailRepository expenseDetailRepository,
            IPaymentRepository paymentRepository,
            UserManager<User> userManager)
        {
            this.groupRepository = groupRepository;
            this.expenseRepository = expenseRepository;
            this.expenseDetailRepository = expenseDetailRepository;
            this.paymentRepository = paymentRepository;
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
     
            var result = await groupRepository.GetAll(p => p.CreatedId.ToString() == GetUserId().Result.ToString());
            return View(result);
        }
    }
}
