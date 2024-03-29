﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Models
{
    public class TimeSheet
    {
        public int TimeSheetId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime WeekStartDate { get; set; }
        public DateTime WeekEndDate { get; set; }
        public decimal TotalHoursWorked { get; set; }
        public string Status { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        

        public TimeSheet(DateTime weekStartDate, DateTime weekEndDate, decimal totalHoursWorked,
                         string status, int approvedBy, DateTime approvedAt)
        {
            WeekStartDate = weekStartDate;
            WeekEndDate = weekEndDate;
            TotalHoursWorked = totalHoursWorked;
            Status = status;
            ApprovedBy = approvedBy;
            ApprovedAt = approvedAt;
        }


        public Employee? Employee { get; set; }
        public User? ApprovedByUser { get; set; }
    }
}
