using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Documents.Queries
{
    public interface IDocumentQueries
    {
        /// <summary>
        /// Get a specific documet, using document ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DocumentQueryResultDto GetDocumentById(Guid id);

        /// <summary>
        /// Get a list of all the documents
        /// </summary>
        /// <returns></returns>
        IEnumerable<DocumentQueryResultDto> GetAllDocuments();
    }
}
