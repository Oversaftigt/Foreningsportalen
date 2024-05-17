using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UnionQueries : IUnionQueries
    {
        // private readonly DbContext _dbContext;
        public UnionQueries(/*DbContext dbContext*/)
        {
            //_dbContext = dbContext;
        }
        UnionQueryResultDto IUnionQueries.GelAllUnions()
        {
            throw new NotImplementedException();
        }

        UnionQueryResultDto IUnionQueries.GelOneUnionById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
