﻿using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces
{
    //For infrastucture
    public interface IAddressQueries
    {
        Task<IEnumerable<AddressQueriesDto>> GetAddressesByUnionAsync(Guid unionId);
        Task<AddressQueriesDto> GetAddressByIdAsync(Guid addressId);
    }
}