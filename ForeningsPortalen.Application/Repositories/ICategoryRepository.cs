using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Add a new category to the database
        /// </summary>
        /// <param name="category"></param>
        void AddCategory(Category category);

        /// <summary>
        /// Update an existing category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="rowVersion"></param>
        void UpdateCategory(Category category, byte[] rowVersion);

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="rowVersion"></param>
        void DeleteCategory(Category category, byte[] rowVersion);

        /// <summary>
        /// Get a specific category, using its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category GetCategory(Guid id);

    }
}
