using ForeningsPortalen.Website.DTOs.Union;

namespace ForeningsPortalen.Website.Contract
{
    public interface IUnionService
    {
        Task<IEnumerable<UnionQueryResultDto>> GetAllUnionsAsync();
    }
}