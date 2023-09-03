using Microsoft.AspNetCore.SignalR;
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;
using IGroupManager = Tricount.BL.Abstract.IGroupManager;

namespace Tricount.MVC.Extensions
{
	public static class TricountManager
	{
		public static IServiceCollection AddTricountServices(this IServiceCollection services)
		{
			services.AddScoped<IExpenseRepository, ExpenseRepository>();
			services.AddScoped<IExpenseDetailRepository, ExpenseDetailRepository>();
			services.AddScoped<IPaymentRepository, PaymentRepository>();
			services.AddScoped<IGroupRepository, GroupRepository>();
			services.AddScoped<IExpenseManager, ExpenseManager>();
			services.AddScoped<IGroupManager, GroupManager>();
			services.AddScoped<IPaymentManager, PaymentManager>();
			services.AddScoped<IExpenseDetailManager, ExpenseDetailManager>();
			services.AddScoped<IInviteManager, InviteManager>();
			services.AddScoped<IInviteRepository, InviteRepository>();



			return services;
		}
	}
}
