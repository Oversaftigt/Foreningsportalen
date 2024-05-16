﻿using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Queries.DTOs
{
    public class CategoryQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
