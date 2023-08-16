using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tricount.Entities.Concrete;
using Tricount.MVC.Data.EntityConfigurations.Abstract;

namespace Tricount.MVC.Data.EntityConfigurations.Concrete
{
    public class ExpenseDetailConfig : BaseConfig<ExpenseDetail>
    {
        public override void Configure(EntityTypeBuilder<ExpenseDetail> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => new
            {
                p.ExpenseId,
                p.GroupId,
                p.UserId

            }).IsUnique();
            builder.Property(p => p.IsPaid).HasDefaultValue(false);
        }
    }
}
