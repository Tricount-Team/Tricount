using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.DAL.EntityConfigurations.Abstract;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.EntityConfigurations.Concrete
{
	public class InviteConfig : BaseConfig<Invite>
	{
		public override void Configure(EntityTypeBuilder<Invite> builder)
		{
			base.Configure(builder);
			builder.Property(p =>p.IsAccepted).HasDefaultValue(false);

		}
	}
}
