using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Union
{
    public class IndexUnion
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
