using System;
namespace Benefits_Backend.API.DTO.Employee
{
    public class EmployeeForViewDTO
    {

        public string StaffId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }

    }
}