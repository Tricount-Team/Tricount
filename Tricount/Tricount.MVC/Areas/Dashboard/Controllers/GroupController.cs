using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models.DTO_s;

namespace Tricount.MVC.Areas.Dashboard.Controllers
{
	[Area("Dashboard")]
	public class GroupController : Controller
	{
		private readonly IExpenseManager expenseManager;
		private readonly IGroupManager groupManager;
		private readonly UserManager<User> userManager;
		private readonly IMapper mapper;
		private readonly IInviteManager inviteManager;

		public GroupController(IGroupManager groupManager, UserManager<User> userManager, IMapper mapper, IInviteManager inviteManager, IExpenseManager expenseManager)
		{
			this.expenseManager = expenseManager;
			this.groupManager = groupManager;
			this.userManager = userManager;
			this.mapper = mapper;
			this.inviteManager = inviteManager;

		}
		[Route("/dashboard/menu")]
		public async Task<IActionResult> Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> PostCreateGroup(GroupDetailViewModel model)
		{
			if (!ModelState.IsValid)
			{
				ModelState.AddModelError(string.Empty, "Fill in the mandatory fields!");
				return View("_Createmodal", model);
			}
			try
			{
				var group = mapper.Map<Group>(model.GroupDTO);
				var user = await userManager.GetUserAsync(User);
				group.ConstituentId = GetUserId();

				await groupManager.Insert(group);
				await groupManager.Update(group);
				user.Groups.Add(group);
				await userManager.UpdateAsync(user);

				return RedirectToAction("Index", "Group");
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\nError message: {ex.Message}");
				return View("_Createmodal", model);


			}


		}
		[HttpGet]
		[Route("dashboard/group/{slug}")]
		public async Task<IActionResult> GetUpdateGroup(string slug)
		{
			GroupDetailViewModel model = new();
			try
			{
				var group = groupManager.GetAll(p => p.Slug == slug).Result.FirstOrDefault();
				model.Group = group;
				return View("_UpdateGroupModal", model);

			}
			catch (Exception ex)
			{

				ModelState.AddModelError("", $"An error was encountered.\n Error message : {ex.Message}");
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
				ModelState.AddModelError("", $"An error was encountered. \n hata mesajı: {ex.Message}");
				return View("_UpdateGroupModal", model);
			}





		}
		[HttpGet]
		[Route("dashbaord/getdeletegroup/{slug}")]
		public IActionResult GetDeleteGroup(string slug)
		{
			GroupDetailViewModel model = new();
			try
			{
				var group = groupManager.GetAll(g => g.Slug == slug).Result.FirstOrDefault();
				model.Group = group;
				return View("_DeleteGroupModal", model);
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n{ex.Message}");
				return RedirectToAction("index");

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
				var invites = await inviteManager.GetAll(p => p.GroupId == model.Group.Id);
				foreach (var invite in invites)
				{
					await inviteManager.Delete(invite);
				}
				await groupManager.Delete(model.Group);
				return RedirectToAction("Index", "Group");

			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n Error Message: {ex.Message}");
				return View("_DeleteGroupModal", model);


			}
		}
		[HttpGet]
		[Route("Dashboard/Group/Detail/{slug}")]
		public async Task<IActionResult> Detail(string slug)
		{
			GroupDetailViewModel viewmodel = new GroupDetailViewModel();
			try
			{
				var groupDetail = await groupManager.GetAllInclude(g => g.Slug == slug, g => g.Users).Result.FirstOrDefaultAsync();
				var user = groupDetail.Users.Where(u => u.Id == GetUserId()).FirstOrDefault();
				viewmodel.Group = groupDetail;

				if (user == null)
				{
					return Redirect("Identitiy/Account/AccessDenied");
				}
				return View(viewmodel);

			}
			catch (Exception ex)
			{
				ModelState.AddModelError(ex.Source, $"An error was encountered.\n {ex.Message}");
				return View(viewmodel);
			}

			
		}
		[HttpGet]
		[Route("dashboard/getcreateinvite/{slug}")]
		public IActionResult GetCreateInvite(string slug)
		{
			GroupDetailViewModel model = new GroupDetailViewModel();
			try
			{
				var group = groupManager.GetAll(i=>i.Slug == slug).Result.FirstOrDefault();
				model.Group= group;
				return View("_InviteModal", model);

			}
			catch (Exception ex)
			{

				ModelState.AddModelError("", $"An error was encountered.\n Error Message: {ex.Message}");
				return RedirectToAction("Index");
			}
		}
		[HttpPost]
		public async Task<IActionResult> PostCreateInvite(GroupDetailViewModel model)
		{
			try
			{
				var user = await userManager.FindByNameAsync(model.Invite.UserName);
				var group =await groupManager.GetAllInclude(g => g.Slug == model.Invite.GroupSlug, g => g.Users).Result.FirstOrDefaultAsync();
				var groupUser = group.Users.FirstOrDefault(u => u.Id == user.Id);

				if (user.Id == GetUserId())
                {
					ModelState.AddModelError("Try again.", "You can't add yourself!");
					return View("_InviteModal", model);
                    
                }
				model.Invite.UserId = user.Id;
				model.Invite.GroupId= group.Id;
				model.Invite.SenderId = GetUserId();
				inviteManager.Insert(model.Invite);
				return RedirectToAction("Index", "Group");



            }
			catch (Exception ex)
			{

				ModelState.AddModelError("", $"An error was encountered.\n Error Message:{ex.Message}");
				return View("_InviteModal", model );

			}
		}
		public async Task<IActionResult> DeniedInvite(string inviteId	)
		{
			try
			{
				var invite = inviteManager.GetAll(i => i.Id == inviteId).Result.FirstOrDefault();
				var group = groupManager.GetAll(g=>g.Id== invite.GroupId).Result.FirstOrDefault();
				var user = await userManager.GetUserAsync(User);
				user.Groups.Add(group);
				await userManager.UpdateAsync(user);

				invite.IsFinished = true;	
				await inviteManager.Update(invite);

				return RedirectToAction("Index", "Group");

			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n Error Message: {ex.Message}");
				return RedirectToAction("Index", "Group");

			}
		}
		public async Task<IActionResult> AcceptInvite(string inviteId)
		{
			try
			{
				var invite = inviteManager.GetAll(i=>i.Id ==inviteId).Result.FirstOrDefault();
				var group = groupManager.GetAll(g=>g.Id==invite.GroupId).Result.FirstOrDefault();	
				var user = await userManager.GetUserAsync(User);

				user.Groups.Add(group);
				await userManager.UpdateAsync(user);

				invite.IsFinished=true;
				await inviteManager.Update(invite);

				return RedirectToAction("Index", "Group");

			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n Error Mesaage: {ex.Message}");
				return RedirectToAction("Index", "Group");
			}
		}
		[HttpGet]

		[Route("dashboard/getcreateexpense/{slug}")]
		public async Task<IActionResult> GetCreateExpense(string slug)
		{
			
			try 
			{
				GroupDetailViewModel model = new GroupDetailViewModel();

				var group = groupManager.GetAll(g=>g.Slug==slug).Result.FirstOrDefault();
				var getGroupWithUsers = await groupManager.GetAllInclude(p=>p.Slug== slug, g=>g.Users).Result.FirstOrDefaultAsync();
				model.Group = getGroupWithUsers;
				return View("_CreateExpenseModal", "Group");

			}
			catch (Exception ex)
			{

				ModelState.AddModelError("", $"An error was encountered\n Error Message: {ex.Message}");
				return RedirectToAction("Index");
			}

		}



		[HttpPost]
		public async Task<IActionResult> PostCreateExpense(GroupDetailViewModel model, string[]? selectedUsers, string[]? selectedUsersInputs)
		{
			try
			{
				var expense = mapper.Map<Expense>(model.ExpenseDTO);
				var group = groupManager.GetAll(g=>g.Slug== model.ExpenseDTO.GroupSlug).Result.FirstOrDefault();
				var payer = userManager.FindByNameAsync(model.ExpenseDTO.PayerId).Result;
				double totalInputAmount = 0;

				for (int x = 0; x < selectedUsersInputs.Length; x++)
				{
                    if (selectedUsersInputs[x] !=null)
                    {
						totalInputAmount += Double.Parse(selectedUsersInputs[x]);
                        
                    }
                }
				if (model.ExpenseDTO.TotalAmount != totalInputAmount && model.ExpenseDTO.IsCheckShowAmountPartial != null) 
				{
					ModelState.AddModelError("", "The amount entered by users  ıs not  equal to the total amount!");
					return View("_CreateExpenseModal", model);
				}

				for (int x = 0; x < selectedUsers.Length; x++)
				{
					var userId = userManager.FindByNameAsync(selectedUsers[x]).Result.Id;

                    if (payer.Id != userId)
                    {
						ExpenseDetail detail = new ExpenseDetail();
						double amountPerPerson = model.ExpenseDTO.TotalAmount / selectedUsers.Length;

                        if (model.ExpenseDTO.IsCheckShowAmountPartial != null)
                        {
							detail.Amount = Double.Parse(selectedUsersInputs[x]);

                        }
                        else
                        {
                            detail.Amount = amountPerPerson;
                        }
						detail.DebtorId = userId;
						expense.ExpenseDetails.Add(detail);


                    }
                }
				expense.PayerId = payer.Id;
				expense.GroupId = group.Id;
				await expenseManager.Insert(expense);
				return RedirectToAction("Index", "Group");
			}
		
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n Error Message :{ex.Message}");
				return View("_CreateExpenseModal", model);
			}

		}
		[HttpGet]
		public async Task<IActionResult> PaidConfirmation(string expenseId)
		{
			try
			{
				var expense = await expenseManager.GetAllInclude(e => e.Id == expenseId, e => e.ExpenseDetails).Result.FirstOrDefaultAsync();
				expense.ExpenseDetails.FirstOrDefault().IsPaid = true;
				await expenseManager.Update(expense);
				return RedirectToAction("Index", "Group");

			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error was encountered.\n Error Message: {ex.Message}");
				return RedirectToAction("Index", "Group");

			
			}
		}


		public string GetUserId()
		{
			var userId =userManager.GetUserId(User).ToString();
			return userId;
		}
	
	}
	
}



