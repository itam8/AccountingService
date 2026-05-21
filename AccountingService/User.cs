using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountingService
{
    public class User
    {
        public User()
        {
            Requests = new HashSet<Request>();
        }

        public long Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Middlename { get; set; }
        public string? Role { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
