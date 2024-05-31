using ForeningsPortalen.Application.Features.Categories.Queries;
using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
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
                  .Include(c => c.Union)
                  .Select(c => new CategoryQueryResultDto()
                  {
                      Id = c.CategoryId,
                      CategoryName = c.Name,
                      ReservationLimitType = c.DurationType.ToString(),
                      MaxBookings = c.MaxBookingsOfThisCategory,
                      UnionId = c.Union.UnionId,
                      RowVersion = c.RowVersion,
                  });

            if (categories is null)
            {
                throw new ArgumentNullException("Error finding categories");
            }

            return categories;
        }
        IEnumerable<CategoryQueryResultDto> ICategoryQueries.GetCategoriesByUnionId(Guid unionId)
        {
            var categories = _dbContext.Category.AsNoTracking()
                 .Include(c => c.Union)
                 .Select(c => new CategoryQueryResultDto()
                 {
                     Id = c.CategoryId,
                     CategoryName = c.Name,
                     ReservationLimitType = c.DurationType.ToString(),
                     MaxBookings = c.MaxBookingsOfThisCategory,
                     UnionId = c.Union.UnionId,
                     RowVersion = c.RowVersion,
                 })
                 .Where(c => c.UnionId == unionId);

            if (categories is null)
            {
                throw new Exception("Error finding categories for union");
            }

            return categories;
        }

        CategoryQueryResultDto ICategoryQueries.GetCategory(Guid id)
        {
            var category = _dbContext.Category.AsNoTracking()
                  .Include(c => c.Union)
                  .Select(c => new CategoryQueryResultDto()
                  {
                      Id = c.CategoryId,
                      CategoryName = c.Name,
                      ReservationLimitType = c.DurationType.ToString(),
                      MaxBookings = c.MaxBookingsOfThisCategory,
                      UnionId = c.Union.UnionId,
                      RowVersion = c.RowVersion,
                  }).FirstOrDefault(c => c.Id == id);

            if (category is null)
            {
                throw new ArgumentNullException("Error finding specific category");
            }

            return category;
        }

    }
}
