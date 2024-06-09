namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;

public class MemberUpdateRequestDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly? MoveOutDate { get; set; }
    public Guid RoleId { get; set; }
    public byte[] RowVersion { get; set; } = [];
}
