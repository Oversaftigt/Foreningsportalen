namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentUpdateRequestDto
    {
        public required string Title { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
