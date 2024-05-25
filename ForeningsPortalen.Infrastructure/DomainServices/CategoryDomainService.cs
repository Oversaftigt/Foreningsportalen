using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.DomainServices
{
    public class CategoryDomainService : ICategoryDomainService
    {
        private readonly ForeningsPortalenContext _context;

        public CategoryDomainService(ForeningsPortalenContext context)
        {
            _context = context;
        }

        IEnumerable<Category> ICategoryDomainService.OtherCategoriesFromUnion(Guid unionId)
        {
            var categories = _context.Category.Where(x => x.Union.UnionId == unionId);
            return categories;
        }
    }
}
