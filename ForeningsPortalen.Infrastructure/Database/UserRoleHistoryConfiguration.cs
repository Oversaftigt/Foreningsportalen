using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database
{
    //public class UserRoleHistoryConfiguration : IEntityTypeConfiguration<UserRoleHistory>
    //{
    //    public void Configure(EntityTypeBuilder<UserRoleHistory> builder)
    //    {

    //        builder.HasKey(urh => new { urh.UserId, urh.RoleId, urh.FromDate });

    //        builder.HasOne(x => x.User)
    //               .WithMany(x => x.RoleHistories)
    //               .HasForeignKey(x => x.UserId);

    //        builder.HasOne(x => x.Role)
    //               .WithMany(x => x.UserHistories)
    //               .HasForeignKey(x => x.RoleId);

    //    }
    //}
}
