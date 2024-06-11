using System.Data;

namespace ForeningsPortalen.Crosscut.TransactionHandling
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits the current transaction.
        /// This method saves all changes made during the transaction to the database.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rolls back the current transaction.
        /// This method discards all changes made during the transaction, reverting the database to its previous state.
        /// </summary>
        void Rollback();

        /// <summary>
        /// Begins a new transaction.
        /// This method starts a new transaction with the specified isolation level.
        /// If no isolation level is specified, it defaults to IsolationLevel.Serializable.
        /// </summary>
        /// <param name="isolationLevel">The isolation level for the transaction. Defaults to IsolationLevel.Serializable.</param>
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Serializable);
    }

}