using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.Domain.Entities
{
    public class SuccessFactor
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public string CostCenter { get; set; }
        public double Tenure { get; set; }
        public string SubBand { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
