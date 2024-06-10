using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Address;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IAddressService
    {
        /// <summary>
        /// Gets a list of all addresses in a union, using union Id
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        Task<IEnumerable<AddressQueryResultDto>> GetAllAddressesAsync(Guid unionId);

        /// <summary>
        /// Create a new address
        /// </summary>
        /// <param name="addressCreateRequestDto"></param>
        /// <returns></returns>
        Task PostAddressAsync(AddressCreateRequestDto addressCreateRequestDto);

        /// <summary>
        /// Get a specific address using address Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        Task<AddressQueryResultDto> GetAddressAsync(Guid addressId);
    }
}
