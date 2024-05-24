using ForeningsPortalen.Website.DTOs.Address;

namespace ForeningsPortalen.Website.Contract
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressQueryResultDto>> GetAllAddressesAsync(Guid unionId);
        Task PostAddressAsync(AddressCreateRequestDto addressCreateRequestDto);
        Task<AddressQueryResultDto> GetAddressAsync(Guid addressId);
    }
}
