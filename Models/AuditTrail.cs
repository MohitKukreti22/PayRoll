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

        public AuditTrail()
        {
            Timestamp = DateTime.Now;
        }

        public User? User { get; set; }
    }
}
}
