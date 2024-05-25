using ForeningsPortalen.Application.Features.Bookings.Commands;
using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingCommands _command;
        private readonly IBookingQueries _queries;

        public BookingController(IBookingCommands command, IBookingQueries queries)
        {
            _command = command;
            _queries = queries;
        }

        [HttpGet("{id}")]
        public ActionResult<BookingQueryResultDto> GetBooking(Guid id)
        {
            var result = _queries.GetBookingById(id);
            if (result == null)
            {
                return BadRequest("Ingen bookinger er fundet");

            }
            return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookingQueryResultDto>> GetAllBookings()
        {
            var result = _queries.GetAllBookings();
            if (result == null)
            {
                return BadRequest("Ingen bookinger er fundet");

            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult PostBooking([FromBody] BookingCreateRequestDto bookingCreateRequestDto)
        {
            try
            {
                _command.CreateBooking(bookingCreateRequestDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete]
        public ActionResult DeleteBooking(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
