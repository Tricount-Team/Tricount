using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Abstract;

namespace Tricount.DAL.EntityConfigurations.Abstract
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasDefaultValue(Guid.NewGuid().ToString());
            builder.Property(p => p.CreateDate).HasDefaultValue(DateTime.Now);

            builder.HasIndex(x => x.Id).IsUnique();

            
        }
    }
}
