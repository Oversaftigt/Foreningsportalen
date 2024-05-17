namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs
{
    public class UserDeleteRequestDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
