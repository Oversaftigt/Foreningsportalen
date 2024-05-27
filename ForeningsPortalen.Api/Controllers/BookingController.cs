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
            try
            {
                var result = _queries.GetBookingById(id);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


        }

        [HttpGet]
        public ActionResult<IEnumerable<BookingQueryResultDto>> GetAllBookings()
        {
            try
            {
                var result = _queries.GetAllBookings();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpGet("ByAddress/{addressId}")]
        public ActionResult<IEnumerable<BookingQueryResultDto>> GetAllBookingsByAddress(Guid addressId)
        {
            try
            {
                var result = _queries.GetAllBookingsByAddress(addressId);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpGet("ByMember/{memberId}")]
        public ActionResult<IEnumerable<BookingQueryResultDto>> GetAllBookingsByMember(Guid memberId)
        {
            try
            {
                var result = _queries.GetAllBookingsByMember(memberId);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

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
