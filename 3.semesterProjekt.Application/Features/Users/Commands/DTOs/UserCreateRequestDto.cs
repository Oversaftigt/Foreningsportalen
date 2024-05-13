using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Commands.DTOs
{
    public class UserCreateRequestDto
    {
        //Base user that does not need an address like a union member. Ex: Admin/UnionEmployees
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        //public Guid? UnionId { get; set; }
    }
}

