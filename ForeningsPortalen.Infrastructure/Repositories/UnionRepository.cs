﻿using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UnionRepository : IUnionRepository
    {
        readonly ForeningsPortalenContext _db;
        public UnionRepository(ForeningsPortalenContext dbContext)
        {
            _db= dbContext;
        }
        void IUnionRepository.CreateUnion(Union union)
        {
            _db.Add(union);
            _db.SaveChanges();
        }

        void IUnionRepository.DeleteUnion()
        {
            throw new NotImplementedException();
        }

        Union IUnionRepository.GetUnion(Guid id)
        {
            var union = _db.Unions.Find(id);
            if (union is null) throw new Exception("Address not found");
            return union;
        }

        void IUnionRepository.UpdateUnion()
        {
            throw new NotImplementedException();
        }
    }
}
