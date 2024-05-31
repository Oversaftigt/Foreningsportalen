namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs
{
    public class UserRoleHistoryCreateRequestDto
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public DateOnly RoleAssigned { get; set; }
    }
}
