namespace ForeningsPortalen.Application.Features.Unions.Commands.DTOs
{
    public class UnionCommandUpdateDto
    {
        public Guid id { get; set; }
        public string UnionName { get; set; }
        public byte[] RowVersion { get; set; }
    }
}