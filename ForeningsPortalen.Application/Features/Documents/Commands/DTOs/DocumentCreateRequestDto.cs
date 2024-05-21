using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentCreateRequestDto
    {
        public required string Title { get; set; }
        public Member Member { get; set; } 
        public DateOnly Date { get; set; }
    }
}
