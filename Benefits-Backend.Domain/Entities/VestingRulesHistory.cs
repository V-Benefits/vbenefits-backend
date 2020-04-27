using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class VestingRulesHistory
    {
        public int Id { get; set; }

        public DateTime FromYearBefore { get; set; }

        public DateTime ToYearBefore { get; set; }

        public decimal VestingPercentageBefore { get; set; }

        public DateTime FromYearAfter { get; set; }

        public DateTime ToYearAfter { get; set; }

        public decimal VestingPercentageAfter { get; set; }

        public int UpdatedById { get; set; }

        public Employee UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
