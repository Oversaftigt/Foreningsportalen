using _3.semesterProjekt.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Queries.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address currentAddress { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
