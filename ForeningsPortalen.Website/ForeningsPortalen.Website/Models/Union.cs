using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models
{
    public class Union
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Guid>? Addresses { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
