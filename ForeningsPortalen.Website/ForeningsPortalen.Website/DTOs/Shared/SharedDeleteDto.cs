namespace ForeningsPortalen.Website.DTOs.Shared
{
    public class SharedDeleteDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
