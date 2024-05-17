using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces
{
    public interface IAddressCommand
    {
        void CreateAddress(AddressCreateRequestDto addressCreateRequestDto);
        void UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto);
        void DeleteAddress(Guid addressId);
    }
}
