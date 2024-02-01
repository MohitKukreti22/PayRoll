using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Models
{
    public class AuditTrail
    {
        public int AuditTrailId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public string Details { get; set; }
        public DateTime Timestamp { get; set; }

        public AuditTrail(string action, string details, DateTime timestamp)
        {
            Action = action;
            Details = details;
            Timestamp = timestamp;
        }

        public User? User { get; set; }
    }
}
}
