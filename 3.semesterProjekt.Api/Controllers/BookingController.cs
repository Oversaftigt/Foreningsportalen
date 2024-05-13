using _3.semesterProjekt.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _3.semesterProjekt.Api.Controllers
{
    public class BookingController
    {
        [HttpGet]
        public ActionResult<Booking> GetBooking()
        {
        }

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> GetAllBookings()
        {

        }

        [HttpPut]
        public IActionResult UpdateBooking()
        {

        }

        [HttpPost]
        public IActionResult PostBooking()
        {

        }

        [HttpDelete]
        public IActionResult DeleteBooking()
        {

        }
        
    }
}
