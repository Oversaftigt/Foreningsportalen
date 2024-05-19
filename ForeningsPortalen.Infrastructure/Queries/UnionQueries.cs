using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UnionQueries : IUnionQueries
    {
        private readonly ForeningsPortalenContext _db;
        public UnionQueries(ForeningsPortalenContext dbContext)
        {
            _db = dbContext;
        }
        IEnumerable<UnionQueryResultDto> IUnionQueries.GetAllUnions()
        {
            var result = _db.Unions.AsNoTracking()
                   .Select(b => new UnionQueryResultDto
                   {
                       Id = b.Id,
                       Name = b.name,
                       RowVersion = b.RowVersion
                   }).ToList();

            return result ?? throw new Exception("Union not found");
        }

        UnionQueryResultDto IUnionQueries.GetUnionById(Guid id)
        {

            var result = _db.Unions.AsNoTracking()
                .Select(b => new UnionQueryResultDto
                {
                    Id = b.Id,
                    Name = b.name,
                    RowVersion = b.RowVersion
                })
                .FirstOrDefault(b => b.Id == id);

            return result ?? throw new Exception("Union not found");
        }


    }
}
