﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace ForeningsPortalen.Crosscut.TransactionHandling.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _db;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DbContext db)
        {
            _db = db;
        }

        void IUnitOfWork.BeginTransaction(IsolationLevel isolationLevel)
        {
            if (_db.Database.CurrentTransaction != null) return;
            _transaction = _db.Database.BeginTransaction();
        }

        void IUnitOfWork.Commit()
        {
            if (_transaction == null) throw new Exception("You must call 'BeginTransaction' before Commit is called");
            _transaction.Commit();
            _transaction.Dispose();
        }

        void IUnitOfWork.Rollback()
        {
            if (_transaction == null) throw new Exception("You must call 'BeginTransaction' before Rollback is called");
            _transaction.Rollback();
            _transaction.Dispose();
        }


    }
}

