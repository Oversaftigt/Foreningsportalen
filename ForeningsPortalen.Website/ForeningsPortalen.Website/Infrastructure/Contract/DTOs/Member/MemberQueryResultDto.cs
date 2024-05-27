namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member
{
    public class MemberQueryResultDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public byte[] RowVersion { get; set; }
    }
}