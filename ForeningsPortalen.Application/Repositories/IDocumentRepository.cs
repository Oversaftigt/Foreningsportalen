using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IDocumentRepository
    {
        void AddDocument(Document doocument);
        void UpdateDocument(Document document, byte[] rowversion);
        void DeleteDocument(Document document, byte[] rowversion);
        Document GetDocument(Guid id);
        List<Document> GetAllDocuments();
    }
}
