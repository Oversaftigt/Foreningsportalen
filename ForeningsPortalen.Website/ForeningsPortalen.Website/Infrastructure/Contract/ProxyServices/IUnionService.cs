using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IUnionService
    {
        Task<IEnumerable<UnionQueryResultDto>> GetAllUnionsAsync();
        Task PostUnionAsync(UnionCreateRequestDto unionCreateRequest);
    }
}