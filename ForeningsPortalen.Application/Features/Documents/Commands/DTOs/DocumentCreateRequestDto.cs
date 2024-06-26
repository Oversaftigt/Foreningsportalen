﻿namespace ForeningsPortalen.Application.Features.Documents.Commands.DTOs
{
    public class DocumentCreateRequestDto
    {
        public required string Title { get; set; }
        public Guid MemberId { get; set; }
        public Guid UnionId { get; set; }

        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
    }
}
