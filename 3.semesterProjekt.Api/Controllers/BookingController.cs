using _3.semesterProjekt.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _3.semesterProjekt.Api.Controllers
{
    public class BookingController
    {
        [HttpGet]
        public async ActionResult<Booking> GetBooking()
        {
        }

        [HttpGet]
        public async ActionResult<IEnumerable<Booking>> GetAllBookings()
        {

        }

        [HttpPut]
        public async IActionResult UpdateBooking()
        {

        }

        [HttpPost]
        public async IActionResult PostBooking()
        {

        }

        [HttpDelete]
        public async IActionResult DeleteBooking()
        {

        }
        
    }
}
