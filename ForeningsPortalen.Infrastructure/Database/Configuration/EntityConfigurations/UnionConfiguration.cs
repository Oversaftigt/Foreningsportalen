using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class UnionConfiguration : IEntityTypeConfiguration<Union>
    {
        public void Configure(EntityTypeBuilder<Union> builder)
        {
            builder.HasKey(x => x.UnionId);
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

            builder.HasMany(x => x.Addresses)
                   .WithOne(x => x.Union)
                   .HasForeignKey("UnionId");

            builder.HasMany(x => x.Documents)
                   .WithOne(x => x.Union)
                   .HasForeignKey("UnionId");

        }
    }
}
