using _3.semesterProjekt.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _3.semesterProjekt.Api.Controllers
{
    public class BookingController
    {
        [HttpGet]
        public async Task<ActionResult<Booking>> GetBooking()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Booking>>> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task< IActionResult> PostBooking()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBooking()
        {
            throw new NotImplementedException();
        }
        
    }
}
