﻿using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.Implementations
{
    public class AddressQuery : IAddressQuery
    {
        private readonly IAddressQueries _addresQueries;

        public AddressQuery(IAddressQueries addresQueries)
        {
            _addresQueries = addresQueries;
        }

        IEnumerable<AddressQueryResultDto> IAddressQuery.GetAddressesByUnionAsync(Guid unionId)
        {
            return _addresQueries.GetAddressesByUnionAsync(unionId);
        }

        AddressQueryResultDto IAddressQuery.GetAddressByIdAsync(Guid addressId)
        {
            return _addresQueries.GetAddressByIdAsync(addressId);
        }
    }
}
