using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces
{
    //For infrastucture
    public interface IAddressQueries
    {
        IEnumerable<AddressQueryResultDto> GetAddressesByUnionAsync(Guid unionId);
        AddressQueryResultDto GetAddressByIdAsync(Guid addressId);
    }
}
