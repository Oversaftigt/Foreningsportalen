using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IDocumentRepository
    {
        void AddDocument(Document doocument);
        void UpdateDocument(Document document, byte[] rowversion);
        void DeleteDocument(Document document, byte[] rowversion);
        Document GetDocument(Guid id);
        // List<Document> GetAllDocuments();
    }
}
