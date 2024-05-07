using _3.semesterProjekt.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class User
    {
        public int Id { get; }

        public Name Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly MoveInDate { get; set; }
        public DateOnly MoveOutDate { get;set; }

    }
}
