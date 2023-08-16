using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tricount.MVC.Data.EntityConfigurations.Concrete
{
    public class UserConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasIndex(p => new
            {
                p.PhoneNumber
            }).IsUnique();
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
        }
    }
}
