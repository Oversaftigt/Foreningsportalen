using Newtonsoft.Json;

namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union
{
    public class UnionQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
