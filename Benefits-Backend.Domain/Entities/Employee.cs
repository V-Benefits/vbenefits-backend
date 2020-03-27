using System;

namespace Benefits_Backend.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }     
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
    }
}
