using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IUnionService
    {
        Task<IEnumerable<UnionQueryResultDto>> GetAllUnionsAsync();
        Task<UnionQueryResultDto> GetUnionByIdAsync(Guid id);
        Task PostUnionAsync(UnionCreateRequestDto unionCreateRequest);
        Task PutUnionAsync(UnionUpdateRequestDto unionUpdateRequest);
    }
}