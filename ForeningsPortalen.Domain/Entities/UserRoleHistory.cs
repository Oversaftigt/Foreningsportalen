﻿namespace ForeningsPortalen.Domain.Entities
{
    public class UserRoleHistory
    {
            public Guid UserId { get; set; }
            public User User { get; set; }

            public Guid RoleId { get; set; }
            public Role Role { get; set; }

            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }
       
    }
}