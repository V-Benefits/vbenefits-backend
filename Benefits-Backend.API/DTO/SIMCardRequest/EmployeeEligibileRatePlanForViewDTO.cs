using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.SIMCardRequest
{
    public class EmployeeEligibileRatePlanForViewDTO
    {
        private EmployeeEligibileRatePlanForViewDTO()
        {

        }
        public EmployeeEligibileRatePlanForViewDTO( int staffId, string band, string ratePlan, int numberOfUsedLines)
        {
            this.StaffId = staffId;
            this.Band = band;
            this.RatePlan = ratePlan;
            this.NumberOfUsedLines = numberOfUsedLines;
        }
        public int StaffId { get; set; }
        public string Band { get; set; }
        public string RatePlan { get; set; }
        public int NumberOfUsedLines { get; set; }
    }
}
