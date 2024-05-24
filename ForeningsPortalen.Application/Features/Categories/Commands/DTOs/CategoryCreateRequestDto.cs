using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Categories.Commands.DTOs
{
    public class CategoryCreateRequestDto
    {
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public Guid UnionId { get; set; }
    }
}
