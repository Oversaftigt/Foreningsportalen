using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UnionRepository : IUnionRepository
    {
        // readonly DbContext _dbContext;
        public UnionRepository(/*DbContext dbContext*/)
        {
            //_dbContext = dbContext;
        }
        void IUnionRepository.CreateUnion(Union union)
        {
            throw new NotImplementedException();
        }

        void IUnionRepository.DeleteUnion()
        {
            throw new NotImplementedException();
        }

        Union IUnionRepository.GetOneUnion(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUnionRepository.UpdateUnion()
        {
            throw new NotImplementedException();
        }
    }
}
