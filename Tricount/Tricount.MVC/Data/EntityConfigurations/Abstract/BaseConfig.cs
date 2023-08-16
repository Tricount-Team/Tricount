using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tricount.Entities.Abstract;

namespace Tricount.MVC.Data.EntityConfigurations.Abstract
{
    public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasDefaultValue(Guid.NewGuid());
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(p => p.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.CreateDate).HasDefaultValue(DateTime.Now);
        }
    }
}
