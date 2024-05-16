using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces
{
    public interface IAddressQuery
    {
        //For api
        IEnumerable<AddressQueryResultDto> GetAddressesByUnionAsync(Guid unionId);
        AddressQueryResultDto GetAddressByIdAsync(Guid addressId);
    }
}
