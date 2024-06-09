using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface ICategoryDomainService
    {
        /// <summary>
        /// Gets a list of categories from the union, based on the union Id
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<Category> OtherCategoriesFromUnion(Guid unionId);
    }
}
