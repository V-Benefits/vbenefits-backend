using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class PensionEnrollmentRules
    {
        public int Id { get; set; }

        public string Band { get; set; }

        public int NumberOfMonthsToEnrollment{ get; set; }
    }
}
