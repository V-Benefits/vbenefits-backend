using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.MedicalRequest
{
    public class MedicalRequestForAddDTO
    {
        public int StaffId { get; set; }
        public string PersonalImage { get; set; }
        public string SpouseName { get; set; }
        public string SpouseImage { get; set; }
        public string MarrigeCertificate { get; set; } 
        public int ChildrenNumber { get; set; }
        public List<ChildrenInfoDTO> ChildrenInfoDTOs { get; set; }
        //public string ChildName { get; set; }
        //public string ChildImage { get; set; }
        //public string BirthCertificate { get; set; }
        public string RequestType { get; set; }

    }
}
