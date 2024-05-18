namespace ForeningsPortalen.WebApp.DTOs.Member
{
    public class MemberQueryResponseDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public Address currentAddress { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
