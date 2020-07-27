using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class SIMCardRequest
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int RequestedById { get; set; }
        public Employee RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public string RequestFor { get; set; }
        public string RequestType { get; set; }
        public string RatePlan { get; set; }
        public string FamilyOrFriendFirstName { get; set; }
        public string MobileNumber { get; set; }
        public string NationalIdImage { get; set; }
        public string Comment { get; set; }
        public string SimSerialNumber { get; set; }
        public string DataSimPlan { get; set; }
    }
}
