using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.PensionRequest
{
    public class PensionRequestDTO
    {
        #region PensionDetails
        public int Id { get; set; }
        public decimal WithdrawalAmmount { get; set; }
        public decimal BeginingBalance { get; set; }
        public decimal CurrentyearContribution { get; set; }
        public int VestingPercent { get; set; }
        public decimal VestedBalance { get; set; }
        public decimal LastRoundWithdrawal { get; set; }
        public decimal ProratedNewContribution { get; set; }
        public decimal CurrentAvailableBalance { get; set; }
        public decimal MaxWithdrawalAmount { get; set; }
        public decimal Income { get; set; }
        #endregion

        #region SuccessFactor
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public string CostCenter { get; set; }
        public double Tenure { get; set; }
        public string SubBand { get; set; }
        public DateTime HiringDate { get; set; }
        #endregion
     
        public bool isRejected { get; set; } = false;
        public bool isCanceled { get; set; } = false;
        public string Status { get; set; } = "Approved";
    }
}
