using System;

namespace Benefits_Backend_Core.Domain.Entities
{
    public class HistoricalMetlifeData
    {
        public int Id { get; set; }
        public DateTime UpdatedON { get; set; }
        public int UpdatedById { get; set; }

        #region Metlife data
        public string Name { get; set; }
        public int CERT { get; set; }
        public float OldBalance { get; set; }
        public float Contribution { get; set; }
        public float Income { get; set; }
        public float Withdrawals { get; set; }
        public float NewBalance { get; set; }
        #endregion

        #region Updated metlife data
        public string UpdatedName { get; set; }

        public int UpdatedCERT { get; set; }
        public float UpdatedOldBalance { get; set; }
        public float UpdatedContribution { get; set; }
        public float UpdatedIncome { get; set; }
        public float UpdatedWithdrawals { get; set; }
        public float UpdatedNewBalance { get; set; }
        #endregion

        //#region Old Data
        //public int StaffId { get; set; }
        //public string Name { get; set; }
        //public string Band { get; set; }
        //public string CC { get; set; }
        //public float Tenure { get; set; }
        //public string SubBand { get; set; }
        //public DateTime HiringDate { get; set; }
        //public float Vesting { get; set; }
        //public float SepRound { get; set; }
        //public bool EligibilityBasedOnLastRound { get; set; }
        //public float VestedBalance { get; set; }
        //public float MaxLoanAmount { get; set; }
        //public float ProrateContribution { get; set; }
        //public float BalanceAsOf28FebSimpleformula { get; set; }

        //#endregion

        //#region Updated data

        //public int UpdatedStaffId { get; set; }
        //public string UpdatedName { get; set; }
        //public string UpdatedBand { get; set; }
        //public string UpdatedCC { get; set; }
        //public float UpdatedTenure { get; set; }
        //public string UpdatedSubBand { get; set; }
        //public DateTime UpdatedHiringDate { get; set; }
        //public float UpdatedVesting { get; set; }
        //public float UpdatedSepRound { get; set; }
        //public bool UpdatedEligibilityBasedOnLastRound { get; set; }
        //public float UpdatedVestedBalance { get; set; }
        //public float UpdatedMaxLoanAmount { get; set; }
        //public float UpdatedProrateContribution { get; set; }
        //public float UpdatedBalanceAsOf28FebSimpleformula { get; set; }
        //#endregion

    }
}
