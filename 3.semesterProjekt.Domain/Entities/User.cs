﻿using _3.semesterProjekt.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
