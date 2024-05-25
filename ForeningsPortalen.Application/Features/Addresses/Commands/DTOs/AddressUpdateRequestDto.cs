namespace ForeningsPortalen.Application.Features.Addresses.Commands.DTOs
{
    public class AddressUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
