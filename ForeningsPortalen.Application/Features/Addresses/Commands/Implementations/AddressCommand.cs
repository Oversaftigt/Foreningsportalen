using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Implementations
{
    public class AddressCommand : IAddressCommand
    {
        Task IAddressCommand.CreateAddress(AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        Task IAddressCommand.UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        Task IAddressCommand.DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
