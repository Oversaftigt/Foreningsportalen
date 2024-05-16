﻿using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Unions.Queries.DTOs
{
    public class UnionQueryResultDto
    {
        public int id { get; }
        public string name { get; set; }
        public List<Address> AddressInformation { get; set; }
        //public Board Board { get; set; }
        //public List<Document> Documents { get; set; }
        //public List<User> Users { get; set; }
    }
}