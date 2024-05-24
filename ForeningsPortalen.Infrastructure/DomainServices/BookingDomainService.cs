﻿using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.DomainServices
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly ForeningsPortalenContext _context;

        public BookingDomainService(ForeningsPortalenContext dbContext)
        {
            _context = dbContext;
        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromAddress(Guid addressId)
        {
            var otherBookingsOnThisAddress = _context.Bookings
                                .Where(x => x.User.Address.AddressId == addressId);

            return otherBookingsOnThisAddress;

        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromUnion(Guid unionId)
        {
            var otherBookingsOnThisUnion = _context.Bookings
                                            .Where(x => x.User.Address.Union.UnionId == unionId);

            return otherBookingsOnThisUnion;
        }
    }
}
