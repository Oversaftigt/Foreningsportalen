﻿using ForeningsPortalen.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class User : Entity
    {
        internal User() : base(Guid.NewGuid())
        {
        }

        internal User(Guid id, string email, string phoneNumber) : base(id)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User(Guid id) : base(id)
        {
        }

        public static User Create(string email, string phoneNumber)
        {
            var user = new User(Guid.NewGuid(), email, phoneNumber);
            return user;
        }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid UnionId { get; set; }

    }
}
