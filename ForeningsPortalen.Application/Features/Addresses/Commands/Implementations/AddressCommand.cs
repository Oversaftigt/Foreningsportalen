﻿using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Implementations
{
    public class AddressCommand : IAddressCommand
    {
        private readonly IAddressRepository _repo;

        public AddressCommand(IAddressRepository repo)
        {
            _repo = repo;
        }

        void IAddressCommand.CreateAddress(AddressCreateRequestDto addressCreateRequestDto)
        {
            Address address = Address.Create(addressCreateRequestDto.StreetName, addressCreateRequestDto.StreetNumber,
                                            addressCreateRequestDto.City, addressCreateRequestDto.ZipCode,
                                            addressCreateRequestDto.allResidents);
            _repo.AddAddress(address);
        }

        void IAddressCommand.UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IAddressCommand.DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
