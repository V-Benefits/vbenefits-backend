﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.API.DTO.Employee
{
    public class EmployeeForEditDTO
    {
        public string StaffId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
    }
}
