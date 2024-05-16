using _3.semesterProjekt.Application.Features.Addresses.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Addresses.Queries.Interfaces
{
    public interface IAddressQuery
    {
        //For api
        IEnumerable<AddressQueryDto> GetAddressesByUnionAsync(Guid unionId);
        AddressQueryDto GetAddressByIdAsync(Guid addressId);
    }
}
