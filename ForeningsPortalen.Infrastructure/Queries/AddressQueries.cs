using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Repositories;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class AddressQueries : IAddressQueries
    {
        private readonly IAddressRepository _repo;

        public AddressQueries(IAddressRepository repo)
        {
            _repo = repo;
        }

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
