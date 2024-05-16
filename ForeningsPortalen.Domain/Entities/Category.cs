﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class Category
    {
        public int Id { get; }
        public string Name { get; set; }
        public BookingDurationType DurationType { get; set; }

    }
}