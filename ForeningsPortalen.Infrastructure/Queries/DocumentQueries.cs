using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                       Title = b.Name,
                       UploadedBy = b.Creator,
                       Date = b.Date,
                       RowVersion = b.RowVersion
                   }).ToList();
            if (!result.Any())
            {
                throw new Exception("Dokumenter blev ikke fundet");
            }

            return result;
        }

        DocumentQueryResultDto IDocumentQueries.GetDocumentById(Guid id)
        {
            var result = _dbContext.Documents.AsNoTracking()
             .Select(b => new DocumentQueryResultDto
        {
            Id = b.DocumentId,
            Title = b.Name,
            UploadedBy = b.Creator,
            Date = b.Date,
            RowVersion = b.RowVersion
             }).FirstOrDefault(b => b.Id ==id);
           
            if (result == null)
            {
                throw new Exception("Dokumenter blev ikke fundet");
            }

            return result;
        }
    }
}
