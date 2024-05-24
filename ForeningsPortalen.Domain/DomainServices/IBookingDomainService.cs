﻿using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IBookingDomainService
    {
        IEnumerable<Booking> OtherBookingsFromUnion(Guid unionId);
        IEnumerable<Booking> OtherBookingsFromAddress(Guid addressId);
    }
}