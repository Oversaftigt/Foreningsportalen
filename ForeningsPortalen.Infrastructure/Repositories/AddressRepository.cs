﻿using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Repositories;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {




        void IAddressRepository.AddAddress(Address address)
        {
            throw new NotImplementedException();
        }

        void IAddressRepository.DeleteAddress(Address address, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        AddressQueryResultDto IAddressRepository.GetAddressById(Guid addressId)
        {
            throw new NotImplementedException();
        }

        List<AddressQueryResultDto> IAddressRepository.GetAddressesByUnion(Guid unionId)
        {
            throw new NotImplementedException();
        }

        void IAddressRepository.UpdateAddress(Address address, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
