using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategori(Category category);
        Category GetCategories(Guid id);
        void UpdateCategori(Category category, byte[] rowVersion);
        void DeleteCategori(Category category, byte[] rowVersion);

    }
}
