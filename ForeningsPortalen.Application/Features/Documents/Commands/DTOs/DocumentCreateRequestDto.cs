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
        public Member UploadedBy { get; set; } //Denne Menber tager den fra domain projektet, er det korrekt? 
        public DateOnly Date { get; set; }
    }
}
