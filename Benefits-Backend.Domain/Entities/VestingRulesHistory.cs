using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class VestingRulesHistory
    {
        public int Id { get; set; }

        public int FromYearBefore { get; set; }

        public int ToYearBefore { get; set; }

        public int VestingPercentageBefore { get; set; }

        public int FromYearAfter { get; set; }

        public int ToYearAfter { get; set; }

        public int VestingPercentageAfter { get; set; }

        public int UpdatedById { get; set; }

        public Employee UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
