using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentDeleteRequestDto
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
