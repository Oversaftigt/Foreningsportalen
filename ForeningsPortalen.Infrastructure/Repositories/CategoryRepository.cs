using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public CategoryRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
        void ICategoryRepository.AddCategory(Category category)
        {
            _dbContext.Add(category);
            _dbContext.SaveChanges();
        }

        void ICategoryRepository.DeleteCategory(Category category, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.GetCategory(Guid id)
        {
            var category = _dbContext.Category
                                     .Include(x => x.Union)
                                     .FirstOrDefault(x => x.CategoryId == id);
            if (category is null) throw new Exception("Category was not found");

            return category;
        }

        void ICategoryRepository.UpdateCategory(Category category, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
