namespace ForeningsPortalen.Application.Shared.DTOs
{
    public class SharedEntityDeleteDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
