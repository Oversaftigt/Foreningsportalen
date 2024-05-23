using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Queries
{
    //For infrastucture
    public interface IAddressQueries
    {
        IEnumerable<AddressQueryResultDto> GetAddressesByUnion(Guid unionId);
        AddressQueryResultDto GetAddressById(Guid addressId);
    }
}
