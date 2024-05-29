using ForeningsPortalen.Application.Features.BookingUnits.Commands;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingUnitController : ControllerBase
    {
        private readonly IBookingUnitCommands _bookingUnitCommands;
        private readonly IBookingUnitQueries _bookingUnitQueries;

        public BookingUnitController(IBookingUnitCommands bookingUnitCommands, IBookingUnitQueries bookingUnitQueries)
        {
            _bookingUnitCommands = bookingUnitCommands;
            _bookingUnitQueries = bookingUnitQueries;
        }

        [HttpGet("/category/{categoryId}/bookingUnit")]
        public ActionResult<IEnumerable<BookingUnitQueryResultDto>> GetBookingUnitsOfUnion(Guid categoryId)
        {
            try
            {
                var bookingUnits = _bookingUnitQueries.GetBookingUnitsByCategoryId(categoryId);
                return Ok(bookingUnits);

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });

            }
        }


        [HttpPost]
        public ActionResult PostBookingUnit([FromBody] BookingUnitCreateRequestDto bookingUnitCreateRequestDto)
        {
            try
            {
                _bookingUnitCommands.CreateBookingUnit(bookingUnitCreateRequestDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

    }
}
