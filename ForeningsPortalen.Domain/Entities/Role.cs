﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class Role
    {
        public int Id { get; }
        public string Type { get; set; }
        //public int ClearanceLevel { get; set; }
    }
}