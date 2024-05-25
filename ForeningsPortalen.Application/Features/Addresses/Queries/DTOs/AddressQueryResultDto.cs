namespace ForeningsPortalen.Application.Features.Addresses.Queries.DTOs
{
    public class AddressQueryResultDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string? Level { get; set; }
        public string? CityName { get; set; }
        public int PostalCode { get; set; }
        public IEnumerable<Guid> AllTenants { get; set; }
        public IEnumerable<Guid>? CurrentTenants { get; set; }
        public Guid UnionId { get; set; }
        public byte[] RowVersion { get; set; }

    }
}
