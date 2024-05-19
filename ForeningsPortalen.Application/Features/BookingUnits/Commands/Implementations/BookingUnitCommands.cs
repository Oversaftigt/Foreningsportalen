using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.Interfaces;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.Implementations
{
    public class BookingUnitCommands : IBookingUnitCommands
    {
        //private readonly IBookingUnitRepository _repository;

        public BookingUnitCommands(/*IBookingUnitRepository repository*/)
        {
            //_repository = repository;
        }

        void IBookingUnitCommands.AddBookingUnit(BookingUnitCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        void IBookingUnitCommands.UpdateBookingUnit(BookingUnitUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        void IBookingUnitCommands.DeleteBookingUnit(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }
    }
}
