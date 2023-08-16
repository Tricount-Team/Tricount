using Tricount.BL.Abstract;
using Tricount.BL.Concrete;
using Tricount.DAL.Repositories.Abstract;
using Tricount.DAL.Repositories.Concrete;

namespace Tricount.MVC.Extentions
{
    public static class TricountManager
    {
        public static IServiceCollection AddTricountServices(this IServiceCollection services)
        {
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpenseDetailRepository, ExpenseDetailRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IExpenseManager, ExpenseManager>();
            services.AddScoped<IExpenseDetailManager, ExpenseDetailManager>();
            services.AddScoped<IGroupManager, GroupManager>();
            services.AddScoped<IPaymentManager, PaymentManager>();

            return services;
        }
    }
}
