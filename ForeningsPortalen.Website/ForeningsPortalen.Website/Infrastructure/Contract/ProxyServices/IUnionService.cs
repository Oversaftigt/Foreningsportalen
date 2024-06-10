using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IUnionService
    {
        /// <summary>
        /// Get a list of all unions
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UnionQueryResultDto>> GetAllUnionsAsync();

        /// <summary>
        /// Create a new union
        /// </summary>
        /// <param name="unionCreateRequest"></param>
        /// <returns></returns>
        Task PostUnionAsync(UnionCreateRequestDto unionCreateRequest);
    }
}