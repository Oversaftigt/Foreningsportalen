using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.Interfaces
{
    public interface IBookingUnitCommands
    {
        void AddBookingUnit(BookingUnitCreateRequestDto dto);
        void UpdateBookingUnit(BookingUnitUpdateRequestDto dto);
        void DeleteBookingUnit(Guid id);
    }
}
