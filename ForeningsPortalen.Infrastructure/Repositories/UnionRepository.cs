using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UnionRepository : IUnionRepository
    {
        readonly ForeningsPortalenContext _db;
        public UnionRepository(ForeningsPortalenContext dbContext)
        {
            _db = dbContext;
        }

        void IUnionRepository.AddUnion(Union union)
        {
            _db.Add(union);
            _db.SaveChanges();
        }
        void IUnionRepository.DeleteUnion(Union union, byte[] rowversion)
        {
            _db.Entry(union).Property(p => p.RowVersion).OriginalValue = rowversion;
            _db.Unions.Remove(union);
            _db.SaveChanges();
        }

        Union IUnionRepository.GetUnion(Guid id)
        {
            var union = _db.Unions.Find(id);
            if (union is null) throw new Exception("Union not found");
            return union;
        }

        void IUnionRepository.UpdateUnion(Union union, byte[] rowversion)
        {
            _db.Entry(union).Property(p => p.RowVersion).OriginalValue = rowversion;
            _db.SaveChanges();
        }
    }
}
