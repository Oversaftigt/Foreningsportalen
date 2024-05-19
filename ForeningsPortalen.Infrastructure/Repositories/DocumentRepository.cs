using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        void IDocumentRepository.DeleteDocument(Document document, byte[] rowversion)
        {
            throw new NotImplementedException();
        }

        Document IDocumentRepository.GetDocument(Guid id)
        {
            throw new NotImplementedException();
        }

        void IDocumentRepository.UpdateDocument(Document document, byte[] rowversion)
        {
            throw new NotImplementedException();
        }
    }
}
