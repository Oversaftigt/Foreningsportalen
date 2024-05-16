using _3.semesterProjekt.Application.Features.Addresses.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Addresses.Queries.Interfaces
{
    //For infrastucture
    public interface IAddressQueries
    {
        IEnumerable<AddressQueriesDto> GetAddressesByUnionAsync(Guid unionId);
        AddressQueriesDto GetAddressByIdAsync(Guid addressId);
    }
}
