namespace ForeningsPortalen.Application.Features.Unions.Queries.DTOs
{
    public class UnionQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
    }
}