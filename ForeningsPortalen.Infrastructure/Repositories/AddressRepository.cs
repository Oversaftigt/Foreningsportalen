using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ForeningsPortalenContext _db;

        public AddressRepository(ForeningsPortalenContext foreningsPortalenContext) 
        {
            _db = foreningsPortalenContext;
        }
        void IAddressRepository.AddAddress(Address address)
        {
                _db.Add(address);
                _db.SaveChanges();
        }

        Address IAddressRepository.GetAddress(Guid id)
        {
            var address = _db.Addresses.Find(id);
            if (address is null) throw new Exception("Address not found");
            return address;
           
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
