using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUnionRepository
    {
        /// <summary>
        /// Get a specific union by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Union GetUnion(Guid id); 

        /// <summary>
        /// Add a new union to the database
        /// </summary>
        /// <param name="union"></param>
        void AddUnion(Union union);

        /// <summary>
        /// Update an exisitng union
        /// </summary>
        /// <param name="union"></param>
        /// <param name="rowversion"></param>
        void UpdateUnion(Union union, byte[] rowversion);

        /// <summary>
        /// Delete an union
        /// </summary>
        /// <param name="union"></param>
        /// <param name="rowversion"></param>
        void DeleteUnion(Union union, byte[] rowversion);
    }
}
