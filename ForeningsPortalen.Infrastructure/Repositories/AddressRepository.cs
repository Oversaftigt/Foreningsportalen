using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        void IAddressRepository.AddAddress(Address address)
        {
            throw new NotImplementedException();
        }

        Address IAddressRepository.GetAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        void IAddressRepository.UpdateAddress(Address address, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
        void IAddressRepository.DeleteAddress(Address address, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

    }
}
