﻿namespace ForeningsPortalen.WebApp.DTOs.Member
{
    public class MemberCreateRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly MoveInDate { get; set; } = new DateOnly();
        public Guid AddressId { get; set; }
        public Guid UnionId { get; set; }
    }
}