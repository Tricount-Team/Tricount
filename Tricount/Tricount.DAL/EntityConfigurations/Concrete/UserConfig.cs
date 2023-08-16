using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.EntityConfigurations.Abstract;
using Tricount.Entities.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.EntityConfigurations.Concrete
{
    public class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => new
            {
                p.UserName,
                p.EmailAddress,
                p.PhoneNumber
            }).IsUnique();
            builder.Property(p => p.EmailAddress).HasMaxLength(128);
            builder.Property(p => p.UserName).HasMaxLength(30);
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.Password).HasMaxLength(50);
        }
    }
}
