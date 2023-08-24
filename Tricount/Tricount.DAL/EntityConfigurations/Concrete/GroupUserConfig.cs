using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.EntityConfigurations.Concrete
{
    public class GroupUserConfig : IEntityTypeConfiguration<GroupUser>
    {
        public void Configure(EntityTypeBuilder<GroupUser> builder)
        {
            builder.HasKey(p => new { p.UserId, p.GroupId });
            //builder.HasOne(p => p.User).WithMany(p => p.GroupUsers).HasForeignKey(gu => gu.UserId);
            //builder.HasOne(p => p.Group).WithMany(p => p.GroupUsers).HasForeignKey(gu => gu.GroupId);
        }
    }
}
