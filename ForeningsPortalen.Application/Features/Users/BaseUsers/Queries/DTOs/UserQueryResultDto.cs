namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Queries.DTOs
{
    public class UserQueryResultDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
