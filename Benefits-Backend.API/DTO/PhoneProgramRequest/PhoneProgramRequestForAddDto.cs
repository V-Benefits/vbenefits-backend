using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.PhoneProgramRequest
{
    public class PhoneProgramRequestForAddDto
    {
        public string RequestFor { get; set; }
        public int RequestById { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
