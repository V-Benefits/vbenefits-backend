using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class PensionEnrollmentRulesHistory
    {
        public int Id { get; set; }

        public string BandBefore { get; set; }

        public int NumberOfMonthsToEnrollmentBefore { get; set; }

        public string BandAfter { get; set; }

        public int NumberOfMonthsToEnrollmentAfter { get; set; }

        public int UpdatedById { get; set; }

        public Employee UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
