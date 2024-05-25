namespace ForeningsPortalen.Website.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
