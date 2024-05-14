using _3.semesterProjekt.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class User : Entity
    {
        public User() : base(Guid.NewGuid())
        {
            
        }

        public User(Guid id, string email, string phoneNumber) : base(id)
        {
            this.Id = id;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
