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
    public class ExpenseConfig : BaseConfig<Expense>
    {
        public override void Configure(EntityTypeBuilder<Expense> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.TotalAmount).HasDefaultValue(0.00);
            builder.Property(p => p.Description).HasMaxLength(100);
            builder.Property(e=>e.IsFinished).HasDefaultValue(false);
        }
    }
}
