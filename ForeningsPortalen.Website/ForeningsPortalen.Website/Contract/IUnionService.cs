using ForeningsPortalen.Website.DTOs.Union;

namespace ForeningsPortalen.WebApp.Contract
{
    public interface IUnionService
    {
        Task<IEnumerable<UnionQueryResultDto>> GetAllUnionsAsync();
    }
}