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
    public class ExpenseDetailConfig: BaseConfig<ExpenseDetail>
    {
        public override void Configure(EntityTypeBuilder<ExpenseDetail> builder)
        {
            base.Configure(builder);
            builder.HasIndex(ed => new
            {
                ed.ExpenseId,
                ed.GroupId,
                ed.UserId
                
            }).IsUnique();
        }
    }
}
