using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.BookingUnit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class IndexModel : PageModel
    {
        private readonly IBookingUnitService _bookingUnitService;

        public IndexModel(IBookingUnitService bookingUnitService)
        {
            _bookingUnitService = bookingUnitService;
        }

        [BindProperty]
        public IList<IndexBookingUnitModel> BookingUnits { get; set; } = default!;

        public async Task OnGetAsync(Guid categoryId)
        {
            var bookingUnitsDto = await _bookingUnitService.GetAllBookingUnitsOfCategory(categoryId);

            if (bookingUnitsDto is null)
            {
                Redirect("/error");
            }
            else
            {
                foreach (var bookingUnit in bookingUnitsDto)
                {
                    BookingUnits.Add(new IndexBookingUnitModel
                    {
                        Id = bookingUnit.Id,
                        Name = bookingUnit.BookingUnitName,
                        MaxBookingDuration = bookingUnit.ReservationLimit,
                        Bookings = bookingUnit.BookingIds,
                        Category = bookingUnit.CategoryId,
                        Deposit = bookingUnit.AdvancePayment,
                        IsActive = bookingUnit.IsBookingUnitActive,
                        Price = bookingUnit.Fee,
                        RowVersion = bookingUnit.RowVersion
                    });
                }
            }

        }
    }
}
