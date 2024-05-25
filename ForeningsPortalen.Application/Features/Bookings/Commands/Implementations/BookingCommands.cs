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
        private readonly IBookingUnitRepository _bookingUnit;
        private readonly IUserRepository _user;
        private readonly IMemberRepository _member;
        private readonly IServiceProvider _serviceProvider;
        private readonly IBookingUnitQueries _bookingUnitQueries;

        public BookingCommands(IUnitOfWork unitOfWork, IBookingRepository bookingRepository, IBookingUnitRepository bookingUnit,
            IUserRepository user, IMemberRepository member, IServiceProvider serviceProvider, IBookingUnitQueries bookingUnitQueries)
        {
            _unitOfWork = unitOfWork;
            _bookingRepository = bookingRepository;
            _bookingUnit = bookingUnit;
            _user = user;
            _member = member;
            _bookingUnitQueries = bookingUnitQueries;
            _serviceProvider = serviceProvider;
        }

        void IBookingCommands.CreateBooking(BookingCreateRequestDto bookingCreateDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var bookingUnits = _bookingUnitQueries.GetAllBookingUnits().ToList();

                if (bookingUnits == null)
                {
                    throw new ArgumentNullException("List of booking units not found");
                }

                var member = _member.GetUnionMember(bookingCreateDto.UserId);

                if (member == null)
                {
                    throw new ArgumentNullException("member not found");
                }

                var newBooking = Booking.CreateBooking(bookingCreateDto.DateOfCreation, bookingCreateDto.StartTime,
                    bookingCreateDto.EndTime, bookingUnits, member, _serviceProvider);

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
            }
        }

        void IBookingCommands.DeleteBooking(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

    }
}
