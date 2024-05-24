namespace ForeningsPortalen.Website.DTOs.Union
{
    public class UnionQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Guid>? Addresses { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
