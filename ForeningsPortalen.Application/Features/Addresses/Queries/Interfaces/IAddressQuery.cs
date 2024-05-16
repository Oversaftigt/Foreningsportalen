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
        Task<IEnumerable<AddressQueryDto>> GetAddressesByUnionAsync(Guid unionId);
        Task<AddressQueryDto> GetAddressByIdAsync(Guid addressId);
    }
}
