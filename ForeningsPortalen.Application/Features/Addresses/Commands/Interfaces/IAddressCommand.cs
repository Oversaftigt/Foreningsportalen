using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces
{
    public interface IAddressCommand
    {
        void CreateAddress(AddressCreateRequestDto addressCreateRequestDto);
        void UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto);
        void DeleteAddress(Guid addressId);
    }
}
