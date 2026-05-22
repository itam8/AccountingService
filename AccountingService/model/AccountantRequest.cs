using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountingService.model
{
    public class AccounantRequest
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string? Name { get; set; }
        public string? ReferenceType { get; set; }
        public int CopiesCount { get; set; }
        public string? Reason { get; set; }
        public string? Status { get; set; }
        public DateTime Date { get; set; }
    }
}
