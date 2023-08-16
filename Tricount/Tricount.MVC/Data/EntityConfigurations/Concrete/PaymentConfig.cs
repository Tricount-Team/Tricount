using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tricount.Entities.Concrete;
using Tricount.MVC.Data.EntityConfigurations.Abstract;

namespace Tricount.MVC.Data.EntityConfigurations.Concrete
{
    public class PaymentConfig : BaseConfig<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Amount).HasDefaultValue(0);
        }
    }
}
