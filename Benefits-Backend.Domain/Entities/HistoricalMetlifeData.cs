using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class HistoricalMetlifeData
    {
        public int Id { get; set; }
        public int CERT { get; set; }
        public string Name { get; set; }
        public float OldBalance { get; set; }
        public float Contribution { get; set; }
        public float Income { get; set; }
        public float Withdrawals { get; set; }
        public float NewBalance { get; set; }
    }
}
