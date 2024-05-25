namespace ForeningsPortalen.Application.Features.UserRoleHistories.Queries.DTOs
{
    public class UserRoleHistoryResultDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
