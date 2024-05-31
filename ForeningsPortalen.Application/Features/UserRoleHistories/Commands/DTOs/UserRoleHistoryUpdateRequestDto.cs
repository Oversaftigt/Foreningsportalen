namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs
{
    public class UserRoleHistoryUpdateRequestDto
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
