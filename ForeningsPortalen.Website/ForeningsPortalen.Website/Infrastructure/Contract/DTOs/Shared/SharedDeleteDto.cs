namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Shared
{
    public class SharedDeleteDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
