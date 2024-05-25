namespace ForeningsPortalen.Application.Features.Roles.Queries.DTOs
{
    public class RoleQueryResultDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool IsPartOfBoard { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
