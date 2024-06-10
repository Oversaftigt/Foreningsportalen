using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Commands
{
    public interface IAddressCommands
    {
        /// <summary>
        /// Creates a new address with the info sent from frontend in the dto
        /// </summary>
        /// <param name="addressCreateRequestDto"></param>
        void CreateAddress(AddressCreateRequestDto addressCreateRequestDto);
        
        /// <summary>
        /// Updates a current address
        /// </summary>
        /// <param name="addressUpdateRequestDto"></param>
        void UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto);
        
        /// <summary>
        /// Deletes an address
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteAddress(SharedEntityDeleteDto deleteDto);
    }
}
