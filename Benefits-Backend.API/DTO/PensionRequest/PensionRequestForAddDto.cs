using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.API.DTO.PensionRequest
{
    public class PensionRequestForAddDto
    {
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
        public bool isEligible { get; set; }
        #region SuccessFactor
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Band { get; set; }
        public string CostCenter { get; set; }
        public double Tenure { get; set; }
        public string SubBand { get; set; }
        public DateTime HiringDate { get; set; }
        #endregion
        public int RequestedById { get; set; }
        public DateTime RequestedOn { get; set; }
        public bool isActive { get; set; } = false;
        public bool isApproved { get; set; }
        public DateTime ApprovedOn { get; set; }
        public DateTime RejectedOn { get; set; }

    }
}
