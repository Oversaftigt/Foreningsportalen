using ForeningsPortalen.Application.Features.Documents.Queries;
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
    }
}
