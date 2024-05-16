using ForeningsPortalen.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    public class BookingController
    {
        [HttpGet]
        public ActionResult<Booking> GetBooking()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<IAsyncEnumerable<Booking>> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult UpdateBooking()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult PostBooking()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult DeleteBooking()
        {
            throw new NotImplementedException();
        }

    }
}
