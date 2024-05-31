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
    public class UnionDomainService : IUnionDomainService
    {
        private readonly ForeningsPortalenContext _dbcontext;

        public UnionDomainService(ForeningsPortalenContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        IEnumerable<Union> IUnionDomainService.OtherUnions()
        {
            var unions = _dbcontext.Unions.ToList();
            return unions;
        }
    }
}
