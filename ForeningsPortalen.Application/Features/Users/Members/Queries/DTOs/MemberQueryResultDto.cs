using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs
{
    public class MemberQueryResultDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address currentAddress { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
