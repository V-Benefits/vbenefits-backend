using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.Entities
{
    public class VestingRules
    {
        public int Id { get; set; }

        public int VestingRulesPercentage { get;  set; }

        public int FromYear { get; set; }

        public int ToYear { get; set; }
    }
}
