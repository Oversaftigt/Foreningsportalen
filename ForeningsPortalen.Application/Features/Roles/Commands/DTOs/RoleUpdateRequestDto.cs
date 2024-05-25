namespace ForeningsPortalen.Application.Features.Roles.Commands.DTOs
{
    public class RoleUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool IsPartofBoard { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
