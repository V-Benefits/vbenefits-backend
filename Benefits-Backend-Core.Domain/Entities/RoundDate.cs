using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.Entities
{
   public class RoundDate
    {
        public RoundDate()
        {
            this.IsActive = true;
        }
        public int Id { get; set; }
        public string RoundName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

    }
}
