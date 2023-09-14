using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Contexts;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models;
using Tricount.MVC.Models.DTO_s.Expense;
using Tricount.MVC.Models.DTO_s.Group;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{

    [Area("Dashboard")]
    public class GroupController : Controller
    {
        private readonly IGroupManager groupManager;
        private readonly IInviteManager inviteManager;
        private readonly IExpenseManager expenseManager;
        private readonly IPaymentManager paymentManager;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public GroupController(
            IGroupManager groupManager,
            IInviteManager inviteManager,
            IExpenseManager expenseManager,
            IPaymentManager paymentManager,
            IMapper mapper,
            UserManager<User> userManager
            )
        {
            this.groupManager = groupManager;
            this.inviteManager = inviteManager;
            this.userManager = userManager;
            this.expenseManager = expenseManager;
            this.paymentManager = paymentManager;
            this.mapper = mapper;
        }

        [Route("/dashboard/menu")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateGroup(GroupDetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Fill in the mandatory fields!");
                return View("_CreateModal", model);
            }
            try
            {
                var group = mapper.Map<Group>(model.GroupDTO);
                var user = await userManager.GetUserAsync(User);
                group.ConstituentId = GetUserId();

                await groupManager.Create(group);
                await groupManager.Update(group);
                user.Groups.Add(group);
                await userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View("_CreateModal", model);
            }
        }

        [HttpGet]
        [Route("/dashboard/getupdategroup/{slug}")]
        public IActionResult GetUpdateGroup(string slug)
        {
            try
            {
                GroupDetailViewModel model = new();

                var group = groupManager.GetGroupWithSlug(slug);
                model.Group = group;
                return View("_UpdateGroupModal", model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostUpdateGroup(GroupDetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("_UpdateGroupModal", model);
            }
            try
            {
                await groupManager.Update(model.Group);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View("_UpdateGroupModal", model);
            }
        }

        [HttpGet]
        [Route("/dashboard/getdeletegroup/{slug}")]
        public IActionResult GetDeleteGroup(string slug)
        {
            try
            {
                GroupDetailViewModel model = new();

                var group = groupManager.GetGroupWithSlug(slug);
                model.Group = group;
                return View("_DeleteGroupModal", model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public async Task<IActionResult> PostDeleteGroup(GroupDetailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("_DeleteGroupModal", model);
            }
            try
            {
                model.Group.Users = groupManager.GetGroupWithSlugAndIncludeUsers(model.Group.Slug).Users;

                var invites = await inviteManager.GetAll(i => i.GroupId == model.Group.Id);
                var group = groupManager.GetAll(g => g.Id == model.Group.Id).Result.FirstOrDefault();
                
                foreach (var invite in invites)
                {
                    var users = userManager.Users.Include(u => u.Groups.Where(g => g.Id == model.Group.Id)).ToList();
                    await inviteManager.Delete(invite);
                }

                await groupManager.Delete(group);
                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View("_DeleteGroupModal", model);
            }
        }

        [HttpGet]
        [Route("/dashboard/detail/{slug}")]
        public async Task<IActionResult> Detail(string slug)
        {
            GroupDetailViewModel model = new();

            try
            {

                var groupWithUsers = groupManager.GetGroupWithSlugAndIncludeUsers(slug);
                var user = groupWithUsers.Users.Where(u => u.Id == GetUserId()).FirstOrDefault();
                model.Group = groupWithUsers;

                if (user == null)
                {
                    return Redirect("/Identity/Account/AccessDenied");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View(model);
            }

        }

        [HttpGet]
        [Route("/dashboard/getcreateinvite/{slug}")]
        public IActionResult GetCreateInvite(string slug)
        {
            try
            {
                GroupDetailViewModel model = new();

                var group = groupManager.GetGroupWithSlug(slug);
                model.Group = group;
                return View("_InviteModal", model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public async Task<IActionResult> PostCreateInvite(GroupDetailViewModel model)
        {
            try
            {
                var user = await userManager.FindByNameAsync(model.Invite.UserName);
                var group = groupManager.GetGroupWithSlugAndIncludeUsers(model.Invite.GroupSlug);
                var groupUser = group.Users.FirstOrDefault(u => u.Id == user.Id);

                if (user.Id == GetUserId())
                {
                    ModelState.AddModelError("Try Again", "You can't add yourself!");
                    return View("_InviteModal", model);
                }
                else if (group == null && user == null && groupUser != null)
                {
                    ModelState.AddModelError("Try Again", "The invitation couldn't be sent!");
                    return View("_InviteModal", model);
                }

                model.Invite.UserId = user.Id;
                model.Invite.GroupId = group.Id;
                model.Invite.SenderId = GetUserId();
                await inviteManager.Create(model.Invite);
                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View("_InviteModal", model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeniedInvite(string? inviteId, string? expenseId)
        {
            try
            {
                if (inviteId != null)
                {
                    var invite = inviteManager.GetAll(i => i.Id == inviteId).Result.FirstOrDefault();
                    invite.IsFinished = true;
                    await inviteManager.Update(invite);
                }
                else if(expenseId != null)
                {
                    var expenseWithExpenseDetails = expenseManager.expenseWithIdAndIncludeE_Details(expenseId);
                    foreach (var expenseDetail in expenseWithExpenseDetails.ExpenseDetails)
                    {
                        if (expenseDetail.ExpenseId == expenseId)
                        {
                            expenseDetail.IsPaid = false;
                        }
                    }
                    await expenseManager.Update(expenseWithExpenseDetails);
                }
                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index", "Group");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AcceptInvite(string? inviteId, string? expenseId)
        {
            try
            {
                if (inviteId != null)
                {
                    var user = await userManager.GetUserAsync(User);
                    var invite = inviteManager.GetAll(i => i.Id == inviteId).Result.FirstOrDefault();
                    var group = groupManager.GetAll(i => i.Id == invite.GroupId).Result.FirstOrDefault();

                    user.Groups.Add(group);
                    await userManager.UpdateAsync(user);

                    invite.IsFinished = true;
                    await inviteManager.Update(invite);
                }
                else if(expenseId != null)
                {
                    Payment paymentModel = new();

                    var expenseWithExpenseDetails = expenseManager.expenseWithIdAndIncludeE_Details(expenseId);

                    foreach (var expenseDetail in expenseWithExpenseDetails.ExpenseDetails)
                    {
                        if (expenseDetail.ExpenseId == expenseId)
                        {
                            expenseDetail.IsApproved = true;
                            paymentModel.Amount = expenseDetail.Amount;
                            paymentModel.DebtorId = expenseDetail.DebtorId;
                            paymentModel.IsFinished = true;
                            paymentModel.ExpenseDetailId = expenseId;

                            expenseDetail.Payments.Add(paymentModel);
                        }
                    }

                    await expenseManager.Update(expenseWithExpenseDetails);

                    expenseWithExpenseDetails.PaymentId = paymentModel.Id;
                    await expenseManager.Update(expenseWithExpenseDetails);
                }

                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index", "Group");
            }
        }

        [HttpGet]
        [Route("/dashboard/getcreateexpense/{slug}")]
        public async Task<IActionResult> GetCreateExpense(string slug)
        {
            
            try
            {
                GroupDetailViewModel model = new();

                var getGroupWithUsers = groupManager.GetGroupWithSlugAndIncludeUsers(slug);
                model.Group = getGroupWithUsers;

                return View("_CreateExpenseModal", model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateExpense(GroupDetailViewModel model, string[]? selectedUsers, string[]? selectedUsersInputs)
        {
            try
            {
                var expense = mapper.Map<Expense>(model.ExpenseDTO);
                var group = groupManager.GetGroupWithSlug(model.ExpenseDTO.GroupSlug);
                var payer = userManager.FindByNameAsync(model.ExpenseDTO.PayerId).Result;
                double totalInputAmount = 0;

                for (int x = 0; x < selectedUsersInputs.Length; x++)
                {
                    if (selectedUsersInputs[x] != null)
                    {
                        totalInputAmount += Double.Parse(selectedUsersInputs[x]);
                    }
                }

                if (model.ExpenseDTO.TotalAmount != totalInputAmount && model.ExpenseDTO.IsCheckedShowAmountPartial != null)
                {
                    ModelState.AddModelError("", "The amount entered by users is not equal to the total amount!");
                    return View("_CreateExpenseModal", model);
                }

                for (int x = 0; x < selectedUsers.Length; x++)
                {
                    var userId = userManager.FindByNameAsync(selectedUsers[x]).Result.Id;

                    if (payer.Id != userId)
                    {
                        ExpenseDetail detail = new ExpenseDetail();
                        double amountPerPerson = Math.Round((model.ExpenseDTO.TotalAmount / selectedUsers.Length), 2);

                        if (model.ExpenseDTO.IsCheckedShowAmountPartial != null)
                        {
                            detail.Amount = Math.Round(Double.Parse(selectedUsersInputs[x]), 2);
                        }
                        else
                        {
                            detail.Amount = amountPerPerson;
                        }
                        detail.ExpenseId = expense.Id;
                        detail.DebtorId = userId;
                        expense.ExpenseDetails.Add(detail);
                    }
                }

                expense.PayerId = payer.Id;
                expense.GroupId = group.Id;
                await expenseManager.Create(expense);
                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return View("_CreateExpenseModal", model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> PaidConfirmation(string expenseId, string debtorId)
        {
            try
            {
                var expenseWithED = expenseManager.expenseWithIdAndIncludeE_Details(expenseId);
                foreach (var expenseDetail in expenseWithED.ExpenseDetails)
                {
                    if (expenseDetail.ExpenseId == expenseId && expenseDetail.DebtorId == debtorId)
                    {
                        expenseDetail.IsPaid = true;
                    }
                }
                await expenseManager.Update(expenseWithED);

                Payment payment = new();
                payment.DebtorId = debtorId;
                

                return RedirectToAction("Index", "Group");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
                return RedirectToAction("Index", "Group");
            }
            
        }

        public string GetUserId()
        {
            var userId = userManager.GetUserId(User).ToString();
            return userId;
        }
    }
}
