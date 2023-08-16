using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tricount.Entities.Concrete;
using Tricount.MVC.Data.EntityConfigurations.Abstract;

namespace Tricount.MVC.Data.EntityConfigurations.Concrete
{
    public class GroupConfig : BaseConfig<Group>
    {
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(100);

        }
    }
}
