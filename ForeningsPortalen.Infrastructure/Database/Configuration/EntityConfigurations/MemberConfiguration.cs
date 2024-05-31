using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        void IEntityTypeConfiguration<Member>.Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.FirstName)
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .IsRequired();

            builder.Property(x => x.MoveInDate)
                   .IsRequired();

            builder.Property(x => x.MoveOutDate);

            //Insert booking logik
        }
    }
}
