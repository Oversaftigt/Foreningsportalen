using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Addresses.Repositories
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        Address GetAddress(Guid id);
        void UpdateAddress(Address address, byte[] rowVersion);
        void DeleteAddress(Address address, byte[] rowVersion);
    }
}
