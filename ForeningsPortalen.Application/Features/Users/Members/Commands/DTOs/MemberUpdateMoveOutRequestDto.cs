namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs
{
    public class MemberUpdateMoveOutRequestDto
    {
        public Guid MemberId { get; set; }
        public DateOnly MoveOutDate { get; set; } = new DateOnly();
        public byte[] RowVersion { get; set; } = [];
    }
}
