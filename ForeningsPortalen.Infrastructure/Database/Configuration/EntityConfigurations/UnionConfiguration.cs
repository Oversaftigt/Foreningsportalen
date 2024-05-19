using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class UnionConfiguration : IEntityTypeConfiguration<Union>
    {
        public void Configure(EntityTypeBuilder<Union> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.name).IsRequired();

            builder.Property(x => x.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

            builder.HasMany(x => x.Addresses)
                   .WithOne(x => x.Union)
                   .HasForeignKey(x => x.Id);

        }
    }
}
