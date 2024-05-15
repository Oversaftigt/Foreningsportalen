using _3.semesterProjekt.Application.Features.Addresses.Queries.DTOs;
using _3.semesterProjekt.Application.Features.Addresses.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Addresses.Queries.Implementations
{
    public class AddressQuery : IAddressQuery
    {
        private readonly AddressQueries _addresQueries;

        public AddressQuery(AddressQueries addresQueries)
        {
            _addresQueries = addresQueries;
        }

        Task<IEnumerable<AddressQueryDto>> IAddressQuery.GetAddressesByUnionAsync(Guid unionId)
        {
            throw new NotImplementedException();
        }

        Task<AddressQueryDto> IAddressQuery.GetAddressByIdAsync(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
