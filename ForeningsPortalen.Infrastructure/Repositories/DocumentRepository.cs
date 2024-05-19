using ForeningsPortalen.Application.Features.Documents.Repositories;
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
    }
}
