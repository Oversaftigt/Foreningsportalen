using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentUpdateRequestDto
    {
        public required string Title { get; set; }
        public Member UpdatedBy { get; set; } //igen har denne Member fra domain projektet + har øndret navnet til at den er updated by i stedet for uploaded by. 
        public DateOnly Date { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
