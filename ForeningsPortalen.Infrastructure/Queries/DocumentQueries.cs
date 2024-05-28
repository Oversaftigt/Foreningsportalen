using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class DocumentQueries : IDocumentQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public DocumentQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        IEnumerable<DocumentQueryResultDto> IDocumentQueries.GetAllDocuments()
        {
            var result = _dbContext.Documents.AsNoTracking()
                    .Select(b => new DocumentQueryResultDto
                    {
                        Id = b.DocumentId,
                        Title = b.FileName,
                        UploadedBy = b.Member,
                        DateOfUpload = b.Date,
                        RowVersion = b.RowVersion
                    }).ToList();

            if (result is null)
            {
                throw new Exception("Error getting all documents");
            }

            return result;
        }

        DocumentQueryResultDto IDocumentQueries.GetDocumentById(Guid id)
        {
            var result = _dbContext.Documents.AsNoTracking()
             .Select(b => new DocumentQueryResultDto
             {
                 Id = b.DocumentId,
                 Title = b.FileName,
                 UploadedBy = b.Member,
                 DateOfUpload = b.Date,
                 RowVersion = b.RowVersion
             }).FirstOrDefault(b => b.Id == id);

            if (result is null)
            {
                throw new Exception("Error finding specific document");
            }

            return result;
        }
    }
}
