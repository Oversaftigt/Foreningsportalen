namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs
{
    public class MemberCreateRequestDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public required Guid AddressId { get; set; }
        public required Guid UnionId { get; set; }
        public required DateOnly MoveInDate { get; set; }
    }
}
