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
        public Member UploadedBy { get; set; } //igen har denne Member fra domain projektet.
        public DateOnly Date { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
