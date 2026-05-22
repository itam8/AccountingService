using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingService.dto
{
    public class RequestCreateDto
    {
        public long UserId { get; set; }
        public string? ReferenceType { get; set; }
        public string? CopiesCount { get; set; }
        public string? Reason { get; set; }
        public string? Status { get; set; }
    }
}
