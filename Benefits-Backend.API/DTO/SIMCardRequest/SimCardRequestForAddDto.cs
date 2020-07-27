using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.SIMCardRequest
{
    public class SimCardRequestForAddDto
    {
        public int StaffId { get; set; }
        public DateTime RequestedOn { get; set; }
        public string RequestFor { get; set; }
        public string RequestType { get; set; }
        public string RatePlan { get; set; }
        public string MobileNumber { get; set; }
        public string NationalIdImage { get; set; }
        public string Comment { get; set; }
        public string SimSerialNumber { get; set; }
        public string DataSimPlan { get; set; }
    }
}
