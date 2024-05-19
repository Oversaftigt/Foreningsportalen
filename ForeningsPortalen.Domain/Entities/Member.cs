namespace ForeningsPortalen.Domain.Entities
{
    public class Member : User
    {
        public Member() { }

        internal Member(Guid id, string firstName,
                             string lastName,
                             DateOnly moveInDate,
                             Union union,
                             Address address, string email, string phoneNumber) : base(id, email, phoneNumber)
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
        //public List<Booking>? Bookings { get; set; }

        public static Member Create(string firstName,
                                         string lastName,
                                         DateOnly moveInDate,
                                         Union union,
                                         Address address,
                                         string email,
                                         string phoneNumber
                                         )
        {
            var newUnionMember = new Member(Guid.NewGuid(), firstName, lastName, moveInDate, union, address, email, phoneNumber);
            return newUnionMember;
        }
    }
}
