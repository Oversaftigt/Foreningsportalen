using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category, byte[] rowVersion);
        void DeleteCategory(Category category, byte[] rowVersion);
        Category GetCategory(Guid id);

    }
}
