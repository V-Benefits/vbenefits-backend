using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.MetlifeData
{
    public class MetlifeDataForAddDto
    {
        public string Name { get; set; }
        public int CERT { get; set; }
        public decimal Oldbalance { get; set; }
        public decimal Contribution { get; set; }
        public decimal Income { get; set; }
        public decimal Withdrawals { get; set; }
        public decimal Newbalance { get; set; }
    }
}