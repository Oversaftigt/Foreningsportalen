using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs
{
    public class UserCreateRequestDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? UnionId { get; set; }
    }
}
