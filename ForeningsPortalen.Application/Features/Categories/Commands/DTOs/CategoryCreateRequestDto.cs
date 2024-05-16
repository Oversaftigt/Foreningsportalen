using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Commands.DTOs
{
    public class CategoryCreateRequestDto
    {
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
    }
}
