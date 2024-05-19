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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        void IEntityTypeConfiguration<Address>.Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StreetName).IsRequired();
            builder.Property(x => x.StreetNumber).IsRequired();
            builder.Property(x => x.Floor);
            builder.Property(x => x.Door);
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.ZipCode).IsRequired();
            
            builder.Property(x => x.RowVersion)
                   .IsRowVersion()
                   .IsRequired();

            builder.HasOne(x => x.Union)
                   .WithMany(u => u.Addresses)  
                   .HasForeignKey(a => a.UnionId).IsRequired();

            builder.HasMany(x => x.Members)
                   .WithOne(x => x.Address)
                   .HasForeignKey(x => x.Id);
        }
    }
}
