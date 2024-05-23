using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        Address GetAddress(Guid id);
        void UpdateAddress(Address address, byte[] rowVersion);
        void DeleteAddress(Address address, byte[] rowVersion);
    }
}
