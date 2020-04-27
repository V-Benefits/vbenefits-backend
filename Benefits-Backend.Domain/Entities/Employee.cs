using System;
using System.Collections.Generic;

namespace Benefits_Backend.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }     
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public ICollection<PensionRequest> PensionRequests { get; set; }
        public ICollection<AppSeetingHistory> AppSeetingHistories { get; set; }
    }
}
