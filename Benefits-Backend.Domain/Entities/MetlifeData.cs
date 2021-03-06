﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class MetlifeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        #region Metlife data
        public int CERT { get; set; }
        public decimal OldBalance { get; set; }
        public decimal Contribution { get; set; }
        public decimal Income { get; set; }
        public decimal Withdrawals { get; set; }
        public decimal NewBalance { get; set; }
        #endregion

        //public int StaffId { get; set; }
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
    }
}
