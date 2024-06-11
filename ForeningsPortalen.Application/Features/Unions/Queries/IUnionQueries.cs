using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQueries
    {
        /// <summary>
        /// Get a specific union by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UnionQueryResultDto GetUnionById(Guid id);

        /// <summary>
        /// Get a list of all unions
        /// </summary>
        /// <returns></returns>
        IEnumerable<UnionQueryResultDto> GetAllUnions();
    }
}
