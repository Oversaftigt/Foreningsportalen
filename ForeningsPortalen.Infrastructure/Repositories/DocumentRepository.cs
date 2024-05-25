using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public DocumentRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IDocumentRepository.AddDocument(Document doocument)
        {
            _dbContext.Add(doocument);
            _dbContext.SaveChanges();
        }

        void IDocumentRepository.DeleteDocument(Document document, byte[] rowversion)
        {
            throw new NotImplementedException();
        }

        Document IDocumentRepository.GetDocument(Guid id)
        {
            var document = _dbContext.Documents.Find(id);
            if (document == null)
            {
                throw new ArgumentNullException("document not found");
            }
            return document;
        }

        void IDocumentRepository.UpdateDocument(Document document, byte[] rowversion)
        {
            throw new NotImplementedException();
        }
    }
}
