using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategori(Category category);
        Category GetCategories(Guid id);
        void UpdateCategori(Category category, byte[] rowVersion);
        void DeleteCategori(Category category, byte[] rowVersion);

    }
}
