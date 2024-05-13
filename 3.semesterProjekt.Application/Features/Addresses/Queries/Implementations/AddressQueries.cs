using _3.semesterProjekt.Application.Features.Addresses.Queries.DTOs;
using _3.semesterProjekt.Application.Features.Addresses.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Addresses.Queries.Implementations
{
    public class AddressQueries : IAddressQueries
    {
        Task<IEnumerable<AddressQueriesDto>> IAddressQueries.GetAddressesByUnionAsync(Guid unionId)
        {
            throw new NotImplementedException();
        }

        Task<AddressQueriesDto> IAddressQueries.GetAddressByIdAsync(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
