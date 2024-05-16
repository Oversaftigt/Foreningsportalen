using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Addresses.Repositories;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                            addressCreateRequestDto.allResidents);
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
