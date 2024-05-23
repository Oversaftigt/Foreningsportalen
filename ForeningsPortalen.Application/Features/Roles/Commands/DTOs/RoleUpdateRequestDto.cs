using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Commands.DTOs
{
    public class RoleUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
