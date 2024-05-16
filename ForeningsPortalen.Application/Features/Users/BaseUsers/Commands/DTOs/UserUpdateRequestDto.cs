using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs
{
    public class UserUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
