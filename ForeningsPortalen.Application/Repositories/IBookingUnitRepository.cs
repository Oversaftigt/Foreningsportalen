using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IBookingUnitRepository
    {
        void AddBookingUnit(BookingUnit bookingUnit );
        BookingUnit GetBookingUnit(Guid id);
        void UpdateBookingUnit(BookingUnit bookingUnit );
        void DeleteBookingUnit(SharedEntityDeleteDto deleteDto);
    }
}
