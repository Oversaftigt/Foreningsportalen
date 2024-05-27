namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Role
{
    public class RoleQueryRequestDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool IsPartOfBoard { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
