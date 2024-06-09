namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union
{
    public class UnionUpdateRequestDto
    {
        public Guid id { get; set; }
        public string UnionName { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
