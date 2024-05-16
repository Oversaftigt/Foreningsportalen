using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Unions.Commands.DTOs
{
    public class UnionCommandDeleteDto
    {
        public int id { get; }
        public byte[] Rowversion { get; set; }
    }
}
