using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class UserRoleHistoryConfiguration : IEntityTypeConfiguration<UserRoleHistory>
    {
        public void Configure(EntityTypeBuilder<UserRoleHistory> builder)
        {

            builder.HasKey(urh => new { urh.UserId, urh.RoleId, urh.FromDate });

            builder.HasOne(x => x.User)
                   .WithMany(x => x.RoleHistories)
                   .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Role)
                   .WithMany(x => x.UserHistories)
                   .HasForeignKey(x => x.RoleId);

        }
    }
}
