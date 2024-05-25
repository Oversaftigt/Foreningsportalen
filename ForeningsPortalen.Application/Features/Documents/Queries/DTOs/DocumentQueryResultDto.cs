using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Documents.Queries.DTOs
{
    public class DocumentQueryResultDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly DateOfUpload { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
