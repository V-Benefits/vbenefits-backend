using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class RatePlanRules
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Band { get; set; }
        public string RatePlan { get; set; }
    }
}
