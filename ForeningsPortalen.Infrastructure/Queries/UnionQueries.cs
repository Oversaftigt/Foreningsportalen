using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UnionQueries : IUnionQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public UnionQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
        IEnumerable<UnionQueryResultDto> IUnionQueries.GetAllUnions()
        {
            throw new NotImplementedException();
        }

        UnionQueryResultDto IUnionQueries.GetUnionById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
