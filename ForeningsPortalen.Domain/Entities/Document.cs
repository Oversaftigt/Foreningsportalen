namespace ForeningsPortalen.Domain.Entities
{
    public class Document
    {
        public int Id { get; }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }
    }
}
