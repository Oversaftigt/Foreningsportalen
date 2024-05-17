using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces
{
    public interface IAddressQuery
    {
        //For api
        IEnumerable<AddressQueryResultDto> GetAddressesByUnionAsync(Guid unionId);
        AddressQueryResultDto GetAddressByIdAsync(Guid addressId);
    }
}
