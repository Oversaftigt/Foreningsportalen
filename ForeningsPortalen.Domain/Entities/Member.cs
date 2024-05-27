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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Booking>? Bookings { get; set; }

        public static Member Create(string firstName,
                                         string lastName,
                                         DateOnly moveInDate,
                                         Union union,
                                         Address address,
                                         string email,
                                         string phoneNumber
                                         )
        {
            var newUnionMember = new Member(firstName, lastName, moveInDate, address, email, phoneNumber);
            return newUnionMember;
        }
    }
}
