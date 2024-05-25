using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.Email)
                   .IsRequired();

            builder.Property(x => x.PhoneNumber)
                   .IsRequired();

            builder.Property(u => u.RowVersion)
                   .IsRowVersion();

            builder.HasDiscriminator<string>("Discriminator")
                   .HasValue<User>("User")
                   .HasValue<Member>("Member");

        }
    }
}
