using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Repositories;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class AddressQueries : IAddressQueries
    {

        IEnumerable<AddressQueryResultDto> IAddressQueries.GetAddressesByUnionAsync(Guid unionId)
        {
            throw new NotImplementedException();
        }

        AddressQueryResultDto IAddressQueries.GetAddressByIdAsync(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }

}
