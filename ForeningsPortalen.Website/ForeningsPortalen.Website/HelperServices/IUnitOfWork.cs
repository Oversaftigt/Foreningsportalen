using System.Data;

namespace ForeningsPortalen.Website.HelperServices
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Serializable);
    }
}
