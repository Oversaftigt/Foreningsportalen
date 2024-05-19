using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.DTOs
{
    public class AddressQueryResultDto
    {
        public Guid Id { get; set; }
        public Guid UnionId { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public List<Guid> Members { get; set; }
        public Member? CurrentMember { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
