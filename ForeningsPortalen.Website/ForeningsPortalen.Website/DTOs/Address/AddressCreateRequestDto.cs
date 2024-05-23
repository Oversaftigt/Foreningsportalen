namespace ForeningsPortalen.Website.DTOs.Address
{
    public class AddressCreateRequestDto
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string? Floor { get; set; }
        public string? Door { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Guid UnionId { get; set; }
    }
}
