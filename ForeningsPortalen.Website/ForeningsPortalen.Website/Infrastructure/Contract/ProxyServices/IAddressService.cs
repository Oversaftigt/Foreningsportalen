using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Address;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressQueryResultDto>> GetAllAddressesAsync(Guid unionId);
        Task PostAddressAsync(AddressCreateRequestDto addressCreateRequestDto);
        Task<AddressQueryResultDto> GetAddressAsync(Guid addressId);
    }
}
