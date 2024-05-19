using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Queries.DTOs
{
    public class DocumentQueryResultDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
