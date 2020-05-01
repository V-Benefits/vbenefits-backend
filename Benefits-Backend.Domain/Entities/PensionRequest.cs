using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class PensionRequest
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
        //public string YearsOfService { get; set; }
        public decimal Income { get; set; }
        public bool isEligible { get; set; }
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

        public int RequestedById { get; set; }
        public Employee RequestedBy { get; set; }

        public DateTime RequestedOn { get; set; }
        public bool isActive { get; set; } = false;
        public bool isApproved { get; set; }

        //public int ApprovedById { get; set; }
        //public Employee ApprovedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        //public int RejectedById { get; set; }

        //public Employee RejectedBy { get; set; }
        public DateTime RejectedOn { get; set; }



    }
}
