using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IAddressRepository
    {
        /// <summary>
        /// Add a new address to the database
        /// </summary>
        /// <param name="address"></param>
        void AddAddress(Address address);

        /// <summary>
        /// Get a specific address from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Address GetAddress(Guid id);

        /// <summary>
        /// Update an address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="rowVersion"></param>
        void UpdateAddress(Address address, byte[] rowVersion);

        /// <summary>
        /// Delete an address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="rowVersion"></param>
        void DeleteAddress(Address address, byte[] rowVersion);
    }
}
