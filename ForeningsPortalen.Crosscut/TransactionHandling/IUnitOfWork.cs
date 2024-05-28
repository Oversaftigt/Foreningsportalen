using System.Data;

namespace ForeningsPortalen.Crosscut.TransactionHandling
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Serializable);
    }
}