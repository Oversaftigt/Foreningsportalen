﻿using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces
{
    public interface IAddressCommand
    {
        Task CreateAddress(AddressCreateRequestDto addressCreateRequestDto);
        Task UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto);
        Task DeleteAddress(Guid addressId);
    }
}