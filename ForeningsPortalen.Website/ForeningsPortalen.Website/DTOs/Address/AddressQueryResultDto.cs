namespace ForeningsPortalen.Website.DTOs.Address
{
    public class AddressQueryResultDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public IEnumerable<Guid>? CurrentMember { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid UnionId { get; set; }
    }
}
