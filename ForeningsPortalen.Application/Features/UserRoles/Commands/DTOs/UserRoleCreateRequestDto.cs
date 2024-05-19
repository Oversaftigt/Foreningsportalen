using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.UserRoles.Commands.DTOs
{
    public class UserRoleCreateRequestDto
    {
        public DateOnly RoleAssigned { get; set; }
        public DateOnly RoleUnassigned { get; set; }

        public User UserId { get; set; }
        public Role RoleId { get; set; }
    }
}
