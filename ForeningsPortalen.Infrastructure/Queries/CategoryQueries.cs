using ForeningsPortalen.Application.Features.Categories.Queries;
using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class CategoryQueries : ICategoryQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public CategoryQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
        IEnumerable<CategoryQueryResultDto> ICategoryQueries.GetCategories()
        {
            var categories = _dbContext.Category.AsNoTracking()
                  .Select(c => new CategoryQueryResultDto()
                  {
                      Name = c.Name,
                      DurationType = c.DurationType,
                      MaxBookingsOfThisCategory = c.MaxBookingsOfThisCategory,
                  });

            if (!categories.Any())
            {
                throw new ArgumentNullException("No categories found");
            }

            return categories;
        }

        CategoryQueryResultDto ICategoryQueries.GetCategory(Guid id)
        {
            var category = _dbContext.Category.AsNoTracking()
                  .Select(c => new CategoryQueryResultDto()
                  {
                      Name = c.Name,
                      DurationType = c.DurationType,
                      MaxBookingsOfThisCategory = c.MaxBookingsOfThisCategory,
                  }).FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                throw new ArgumentNullException("No categories found");
            }

            return category;
        }
    }
}
