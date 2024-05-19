using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Commands
{
    public interface IAddressCommands
    {
        void CreateAddress(AddressCreateRequestDto addressCreateRequestDto);
        void UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto);
        void DeleteAddress(SharedEntityDeleteDto deleteDto);
    }
}
