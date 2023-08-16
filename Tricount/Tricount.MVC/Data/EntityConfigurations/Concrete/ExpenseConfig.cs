using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tricount.Entities.Concrete;
using Tricount.MVC.Data.EntityConfigurations.Abstract;

namespace Tricount.MVC.Data.EntityConfigurations.Concrete
{
    public class ExpenseConfig : BaseConfig<Expense>
    {
        public override void Configure(EntityTypeBuilder<Expense> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Amount).HasDefaultValue(0);
            builder.Property(p => p.Description).HasMaxLength(100);
        }
    }
}
