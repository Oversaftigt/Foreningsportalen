namespace ForeningsPortalen.Application.Features.Addresses.Commands.DTOs
{
    public class AddressCreateRequestDto
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string? Level { get; set; }
        public string? Door { get; set; }
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        public Guid UnionId { get; set; }
    }
}
