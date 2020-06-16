using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.MedicalRequest
{
    public class SpouseMedicalRequestForAddDTO
    {
        public int StaffId { get; set; }
        public string SpouseName { get; set; }
        public string SpouseImage { get; set; }
        public string MarrigeCertificate { get; set; }
    }
}
