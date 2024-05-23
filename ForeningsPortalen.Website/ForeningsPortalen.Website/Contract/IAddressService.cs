using ForeningsPortalen.Website.DTOs.Address;

namespace ForeningsPortalen.WebApp.Contract
{
    public interface IAddressService
    {
        Task<IEnumerable<AddressQueryResultDto>> GetAllAddressesAsync(Guid unionId);
    }
}
