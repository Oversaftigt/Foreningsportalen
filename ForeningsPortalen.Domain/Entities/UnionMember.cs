using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class UnionMember : User
    {
        internal UnionMember() : base(Guid.NewGuid()) 

        {
        
        }

        internal UnionMember(Guid id, string firstName, 
                             string lastName, 
                             DateOnly moveInDate,
                             Union union, 
                             Address address) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            MoveInDate = moveInDate;
            Union = union;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public Union Union { get; set; }
        public Address Address { get; set; }
        public List<Booking>? Bookings { get; set; }

        public static UnionMember Create(string firstName,
                                         string lastName,
                                         DateOnly moveInDate,
                                         Union union,
                                         Address address
                                         )
        {
            var newUnionMember = new UnionMember(Guid.NewGuid(),firstName, lastName, moveInDate, union, address);
            return newUnionMember;
        }
    }
}
