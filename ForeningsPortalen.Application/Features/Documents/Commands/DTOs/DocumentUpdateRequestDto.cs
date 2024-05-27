namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentUpdateRequestDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public byte[] DocContent { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
