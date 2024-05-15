namespace _3.semesterProjekt.Application.Features.Users.Commands.DTOs
{
    public class UserDeleteRequestDto
    {
            public Guid Id { get; set; }
            public byte[] RowVersion { get; set; } = [];
        
    }
}