﻿using _3.semesterProjekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Addresses.Repositories
{
    public interface IAddressRepository
    {
        void AddAddress(Address address);
        Address GetAddressById(Guid addressId);
        List<Address> GetAddressesByUnion(Guid unionId);
        void UpdateAddress(Address address, byte[] rowVersion);
        void DeleteAddress(Address address, byte[] rowVersion);
    }
}
