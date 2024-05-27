using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Bookings.Commands.Implementations
{
    public class BookingCommands : IBookingCommands
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookingRepository _bookingRepository;
        private readonly IBookingUnitRepository _bookingUnitRepository;
        private readonly IUserRepository _user;
        private readonly IMemberRepository _member;
        private readonly IServiceProvider _serviceProvider;
        private readonly IBookingUnitQueries _bookingUnitQueries;

        public BookingCommands(IUnitOfWork unitOfWork, IBookingRepository bookingRepository, IBookingUnitRepository bookingUnit,
            IUserRepository user, IMemberRepository member, IServiceProvider serviceProvider, IBookingUnitQueries bookingUnitQueries)
        {
            _unitOfWork = unitOfWork;
            _bookingRepository = bookingRepository;
            _bookingUnitRepository = bookingUnit;
            _user = user;
            _member = member;
            _bookingUnitQueries = bookingUnitQueries;
            _serviceProvider = serviceProvider;
        }

        void IBookingCommands.CreateBooking(BookingCreateRequestDto dto)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                //Create bookingunits first
                List<BookingUnit> bookingUnits = new();
                foreach (Guid bookingUnitGuid in dto.BookingUnitsID)
                {
                    var bookingUnit = (_bookingUnitRepository.GetBookingUnit(bookingUnitGuid));
                    bookingUnits.Add(bookingUnit);
                }
                if (bookingUnits == null) throw new ArgumentNullException("List of booking units not found");

                //then create member
                var member = _member.GetUnionMember(dto.UserId);
                if (member == null) throw new ArgumentNullException("member not found");


                //then the booking
                var newBooking = Booking.CreateBooking(dto.DateOfCreation, dto.StartTime,
                    dto.EndTime, bookingUnits, member, _serviceProvider);

                _bookingRepository.AddBooking(newBooking);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork?.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
                throw;
            }
        }

        void IBookingCommands.DeleteBooking(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

    }
}
