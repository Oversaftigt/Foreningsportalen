using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.Implementations
{
    public class BookingUnitCommands : IBookingUnitCommands
    {
        private readonly IBookingUnitRepository _bookingUnitRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBookingRepository _bookingRepository;

        public BookingUnitCommands(IBookingUnitRepository bookingUnitRepository, IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository, IBookingRepository bookingRepository)
        {
            _bookingUnitRepository = bookingUnitRepository;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _bookingRepository = bookingRepository;

        }

        void IBookingUnitCommands.CreateBookingUnit(BookingUnitCreateRequestDto dto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var category = _categoryRepository.GetCategories(dto.CategoryId);
                if (category == null)
                {
                    throw new ArgumentNullException("Member not found");
                }
                var booking = _bookingRepository.GetAllBookings();
                if (booking == null)
                {
                    throw new ArgumentNullException("Member not found");
                }

                var newBookingUnit = BookingUnit.CreateBookingUnit(dto.Name, dto.IsActive, dto.Deposit,
                                        dto.Price, dto.MaxBookingDuration, category, booking);
                _bookingUnitRepository.AddBookingUnit(newBookingUnit);
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
