using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        void ICategoryRepository.UpdateCategory(Category category, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
