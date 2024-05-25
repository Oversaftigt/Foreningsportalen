namespace ForeningsPortalen.Website.Models.Address
{
    public class CreateAddressModel
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string? Floor { get; set; }
        public string? Door { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
