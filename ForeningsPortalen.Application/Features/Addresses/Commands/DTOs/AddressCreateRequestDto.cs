using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.DTOs
{
    public class AddressCreateRequestDto
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public List<User> allResidents { get; set; }
    }
}
