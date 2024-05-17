using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.DTOs
{
    public class AddressQueryResultDto
    {
        public Guid Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public List<User> allResidents { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
