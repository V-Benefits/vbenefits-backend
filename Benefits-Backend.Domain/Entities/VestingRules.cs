using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class VestingRules
    {
        public int Id { get; set; }

        public int VestingRulesNumber { get; private set; }

        public DateTime FromYear { get; set; }

        public DateTime ToYear { get; set; }

        public decimal VestingPercentage { get; set; }
    }
}
