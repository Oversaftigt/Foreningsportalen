using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Implementations
{
    public class AddressCommands : IAddressCommands
    {
        private readonly IAddressRepository _repo;

        public AddressCommands(IAddressRepository repo)
        {
            _repo = repo;
        }

        void IAddressCommands.CreateAddress(AddressCreateRequestDto addressCreateRequestDto)
        {
            Address address = Address.Create(addressCreateRequestDto.StreetName, addressCreateRequestDto.StreetNumber,
                                            addressCreateRequestDto.City, addressCreateRequestDto.ZipCode,
                                            addressCreateRequestDto.Members);
            _repo.AddAddress(address);
        }

        void IAddressCommands.UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IAddressCommands.DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
