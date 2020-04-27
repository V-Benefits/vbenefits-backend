using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class VestingRules
    {
        public int Id { get; set; }
        public string Band { get; set; }
        public int EnrollmentAfterMonths { get; set; }
        public DateTime EditedOn { get; set; }

    }
}
