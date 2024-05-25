using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Address
{
    public class DeleteAddressModel
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string? Floor { get; set; }
        public string? Door { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public IEnumerable<Guid>? CurrentMember { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
