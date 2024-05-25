using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface ICategoryDomainService
    {
        IEnumerable<Category> OtherCategoriesFromUnion(Guid unionId);
    }
}
