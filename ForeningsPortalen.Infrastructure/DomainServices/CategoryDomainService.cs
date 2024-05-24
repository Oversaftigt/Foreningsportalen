using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
