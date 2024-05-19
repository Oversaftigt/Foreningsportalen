using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Commands.DTOs
{
    public class BoardDeleterequestDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
