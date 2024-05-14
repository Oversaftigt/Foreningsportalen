using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class UnionMember : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public Union Union { get; set; }
        public Address Address { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
