using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries;
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
        private readonly IServiceProvider _serviceProvider;
        private readonly ICategoryQueries _categoryQueries;

        public BookingUnitCommands(IBookingUnitRepository bookingUnitRepository, IUnitOfWork unitOfWork,
            ICategoryRepository categoryRepository, IBookingRepository bookingRepository, ICategoryQueries categoryQueries, IServiceProvider serviceProvider)
        {
            _bookingUnitRepository = bookingUnitRepository;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _bookingRepository = bookingRepository;
            _categoryQueries = categoryQueries;

            _serviceProvider = serviceProvider;
        }

        void IBookingUnitCommands.CreateBookingUnit(BookingUnitCreateRequestDto dto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var category = _categoryRepository.GetCategory(dto.CategoryId);
                if (category == null)
                {
                    throw new ArgumentNullException("Member not found");
                }


                var newBookingUnit = BookingUnit.CreateBookingUnit(dto.BookingUnitName, dto.IsBookingUnitActive, dto.AdvancePayment,
                                        dto.Fee, dto.ReservationLimit, category, _serviceProvider);

                if (newBookingUnit == null)
                {
                    throw new ArgumentNullException("BookingUnit not found");
                }
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
