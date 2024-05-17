namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs
{
    public class MemberDeleteRequestDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
