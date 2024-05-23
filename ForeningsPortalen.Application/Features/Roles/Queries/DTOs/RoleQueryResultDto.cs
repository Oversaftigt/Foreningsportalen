using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Queries.DTOs
{
    public class RoleQueryResultDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserRoleHistory> UserHistories { get; set; } = new List<UserRoleHistory>();
        public byte[] Rowversion { get; set; }
    }
}
