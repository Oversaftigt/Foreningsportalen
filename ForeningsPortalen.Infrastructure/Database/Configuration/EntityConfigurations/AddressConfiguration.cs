using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        void IEntityTypeConfiguration<Address>.Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.AddressId);

            builder.Property(x => x.StreetName).IsRequired();
            builder.Property(x => x.StreetNumber).IsRequired();
            builder.Property(x => x.Floor);
            builder.Property(x => x.Door);
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.ZipCode).IsRequired();

            builder.Property(x => x.RowVersion)
                   .IsRowVersion()
                   .IsRequired();

            builder.HasMany(x => x.Members)
                   .WithOne(x => x.Address)
                   .HasForeignKey("AddressId");
        }
    }
}
