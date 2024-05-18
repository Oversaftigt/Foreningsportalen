namespace ForeningsPortalen.WebApp.DTOs
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public byte[] RowVersion { get; set; }

        public IEnumerable<Member> TenantHistory { get; set; }
    }
}
