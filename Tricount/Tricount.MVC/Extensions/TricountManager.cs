
using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;



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
			services.AddScoped<IPaymentManager, PaymentManager>();
			services.AddScoped<IExpenseDetailManager, ExpenseDetailManager>();
			services.AddScoped<IInviteManager, InviteManager>();
			services.AddScoped<IInviteRepository, InviteRepository>();
            services.AddScoped<IGroupManager, GroupManager>();




            return services;
		}
	}
}
