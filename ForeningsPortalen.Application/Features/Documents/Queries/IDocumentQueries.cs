using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Documents.Queries
{
    public interface IDocumentQueries
    {
        //Read metoder skal skrives og implementeres i infrastructure
        DocumentQueryResultDto GetDocumentById(Guid id);
        IEnumerable<DocumentQueryResultDto> GetAllDocuments();
    }
}
