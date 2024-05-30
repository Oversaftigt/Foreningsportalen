using ForeningsPortalen.Domain.DomainServices;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

using System.Data;
using System.Text.RegularExpressions;

namespace ForeningsPortalen.Domain.Entities
{
    public class Member : User
    {
        protected Member() { }

        internal Member(string firstName,
                             string lastName,
                             DateOnly moveInDate,
                             Address address, string email, string phoneNumber) : base(email, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            MoveInDate = moveInDate;
            Address = address;
        }

        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public DateOnly MoveInDate { get; init; }
        public DateOnly? MoveOutDate { get; set; }
        public Address Address { get; init; }
        public  IEnumerable<Role> Roles { get; protected set; }
        public IEnumerable<Booking>? Bookings { get; protected set; }

        public static Member Create(string firstName, string lastName, DateTime moveInDate,Union union,
                                    Address address, string email, string phoneNumber)
        {
            if (firstName == null) throw new ArgumentNullException(nameof(firstName));
            if (lastName == null) throw new ArgumentNullException(nameof(lastName));
            if (moveInDate != default) throw new ArgumentNullException(nameof(moveInDate));  
            if (union == null) throw new ArgumentNullException(nameof(union));
            if (address == null) throw new ArgumentNullException(nameof(address));
            if (email == null) throw new ArgumentNullException(nameof(email));
            if(!IsPhoneNumberValid(phoneNumber)) throw new InvalidOperationException(nameof(phoneNumber));
            
            var dateOfMoveIn = DateOnly.FromDateTime(moveInDate);

            var newUnionMember = new Member(firstName, lastName, dateOfMoveIn, address, email, phoneNumber);
            return newUnionMember;
        }

        public void Update(string firstName, string lastName, DateTime moveOutDate, string phoneNumber, Guid roleId)
        {
            if (firstName == null) throw new ArgumentNullException(nameof(firstName));
            if (lastName == null) throw new ArgumentNullException(nameof(lastName));

            if (!IsPhoneNumberValid(phoneNumber)) throw new InvalidOperationException(nameof(phoneNumber));
            if (moveOutDate != default)
            {
                if (!IsMoveOutDateValid(moveOutDate)) throw new InvalidOperationException(nameof(moveOutDate));
                MoveOutDate = DateOnly.FromDateTime(moveOutDate);
            }

            var currentRole = RoleHistories.FirstOrDefault(x => x.ToDate == null);

            if (roleId != currentRole.RoleId)
            {
                RoleHistories.Add(new RoleHistory
                {
                    UserId = UserId, 
                    RoleId = roleId,
                    FromDate = DateTime.Now,
                    ToDate = null 
                });

            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            

        }

        private static bool IsPhoneNumberValid(string phoneNumber)
        {
            var pattern = @"^\+?\d{ 0,3}[\d\s]{ 7,}$";

            var match = Regex.Match(phoneNumber, pattern);
            return match.Success;
        }

        private static bool IsMoveOutDateValid(DateTime moveOutDate)
        {
            if (moveOutDate == default) return false;
            if (moveOutDate < DateTime.MinValue && moveOutDate > DateTime.MaxValue) return false;
            if (moveOutDate < DateTime.Today) return false;
            return true;
        }

    }
}
