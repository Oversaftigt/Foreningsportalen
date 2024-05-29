namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member
{
    public class MemberQueryResultDto
    {
        public required Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string PhoneNumber { get; set; }
        public required DateOnly MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public required Guid RoleId { get; set; }
        public required byte[] RowVersion { get; set; }
    }
}