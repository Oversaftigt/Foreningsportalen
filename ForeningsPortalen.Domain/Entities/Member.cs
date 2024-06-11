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

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly MoveInDate { get; private set; }
        public DateOnly? MoveOutDate { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Booking>? Bookings { get; private set; }

        public static Member Create(string firstName,
                                         string lastName,
                                         DateTime moveInDate,
                                         Union union,
                                         Address address,
                                         string email,
                                         string phoneNumber
                                         )
        {

            var dateOfMoveIn = DateOnly.FromDateTime( moveInDate );

            var newUnionMember = new Member(firstName, lastName, dateOfMoveIn , address, email, phoneNumber);
            return newUnionMember;
        }
    }
}
