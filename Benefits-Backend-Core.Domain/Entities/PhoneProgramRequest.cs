using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.Entities
{
   public class PhoneProgramRequest
    {
        public int Id { get; set; }
        public string RequestFor { get; set; }
        public int RequestById { get; set; }
        public Employee RequestBy { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
