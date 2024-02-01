using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeId { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }

         public LeaveRequest()
        {
            StartDate = DateTime.Now; 
            EndDate = DateTime.Now;   
            ApprovedAt = DateTime.Now; 
        }

        public Employee? Employee { get; set; }
        public User? ApprovedByUser { get; set; }
    }
}
