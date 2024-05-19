using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Queries
{
    public interface IDocumentQueries
    {
        //Read metoder skal skrives og implementeres i infrastructure
        DocumentQueryResultDto GetDocumentById(Guid id);
        IEnumerable<DocumentQueryResultDto> GetAllDocuments();
    }
}
