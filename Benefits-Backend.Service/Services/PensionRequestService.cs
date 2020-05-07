using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class PensionRequestService : IPensionRequestService
    {
        private readonly IPensionRequestRepository pensionRequestRepository;
        private readonly IMetlifeDataRepository metlifeDataRepository;

        private readonly IVestingRulesService vestingRulesService;
        private readonly IPensionEnrollmentRulesService pensionEnrollmentRulesService;
        private readonly IAppSettingService appSettingService;
        private readonly IEnumerable<VestingRules> vestingRulesList;
        private readonly IEnumerable<PensionEnrollmentRules> enrollmentRulesList;
        public PensionRequestService(IPensionRequestRepository pensionRequestRepository, IMetlifeDataRepository metlifeDataRepository, IVestingRulesService vestingRulesService, IPensionEnrollmentRulesService pensionEnrollmentRulesService, IAppSettingService appSettingService)
        {
            this.pensionRequestRepository = pensionRequestRepository;
            this.metlifeDataRepository = metlifeDataRepository;

            this.vestingRulesService = vestingRulesService;
            this.pensionEnrollmentRulesService = pensionEnrollmentRulesService;
            this.appSettingService = appSettingService;

            vestingRulesList = vestingRulesService.GetVestingRules();
            enrollmentRulesList = pensionEnrollmentRulesService.GetEnrollmentRules();
            appSettingService.GetPensionMaxPercent();



        }
        public PensionRequest CreatePensionRequest(PensionRequest pensionRequest)
        {
            pensionRequestRepository.Add(pensionRequest);
            return pensionRequest;
        }

        public PensionRequest CalculatePensionFormula(int userStaffId, SuccessFactor successFactorData)
        {
       
            PensionRequest pension = new PensionRequest();
            pension.isEligible = true;

            if (this.IsWithdraw(userStaffId))
            {
                pension.isEligible = false;
                return pension;
            } 

          pension.VestingPercent = GetVestingPercent(successFactorData.Band, successFactorData.Tenure);
            if (pension.VestingPercent == -1)
            {
                pension.isEligible = false;
                return pension;
            }

            pension = FillPensionObject(userStaffId ,successFactorData , pension);
            return pension;
        }


        public int GetVestingPercent(string band, double tenure)
        {
          
            var enrollmentMonths = enrollmentRulesList.Where(e => e.Band == band).FirstOrDefault().NumberOfMonthsToEnrollment;
            var enrollmentYears = enrollmentMonths / 12.0; 

            var minYear = vestingRulesList.ToList().Min(vr => vr.FromYear);
            var maxYear = vestingRulesList.ToList().Max(vr => vr.FromYear);

            if (tenure < minYear)
            {
                return -1;

            }
            else if(tenure> maxYear)
            {
                return vestingRulesList.Where(x => x.FromYear == maxYear).FirstOrDefault().VestingRulesPercentage;
            }
            else
            {
                return vestingRulesList.Where(x => (x.FromYear + enrollmentYears) < tenure &&
               (x.ToYear + enrollmentYears) > tenure).FirstOrDefault().VestingRulesPercentage;
            }
        }

        public PensionRequest FillPensionObject(int userStaffId, SuccessFactor successFactorData, PensionRequest pension)
        {
            // pension.Id = userStaffId;
          //  PensionRequest pension = new PensionRequest();
            MetlifeData metlifeData = metlifeDataRepository.GetMetlifeDataForUser(userStaffId);

            // metlife data
            pension.BeginingBalance = metlifeData.OldBalance;
            pension.CurrentyearContribution = metlifeData.Contribution;
            pension.CurrentAvailableBalance = metlifeData.NewBalance;
            pension.WithdrawalAmmount = metlifeData.Withdrawals;
            pension.LastRoundWithdrawal = metlifeData.Withdrawals;
            pension.Income = metlifeData.Income;
            ///

            /// calculated data 
            pension.VestedBalance = ((pension.VestingPercent * pension.CurrentAvailableBalance) / 100);
            pension.MaxWithdrawalAmount = ((pension.VestedBalance * 65) / 100);
            pension.ProratedNewContribution = ((pension.CurrentyearContribution / 12) * 8);
            ////

            // success factor data 
            pension.StaffId = successFactorData.StaffId;
            pension.Name = successFactorData.Name;
            pension.Band = successFactorData.Band;
            pension.CostCenter = successFactorData.CostCenter;
            pension.Tenure = successFactorData.Tenure;
            pension.SubBand = successFactorData.SubBand;
            pension.HiringDate = successFactorData.HiringDate;
            ////

            // dummy data related to the request 
            pension.RequestedById = 1;
            pension.RequestedOn = DateTime.Now;
            pension.isActive = true;
            pension.isApproved = false;
            pension.ApprovedOn = DateTime.Now;
            pension.RejectedOn = DateTime.Now;

            return pension;
        }

        public bool IsWithdraw(int userStaffId)
        {
            //If metlifedata last round withdrawal != zero then notEligible 
            MetlifeData metlifeData = metlifeDataRepository.GetMetlifeDataForUser(userStaffId);

            if (metlifeData.Withdrawals != 0){
                return true;
            } else {
                return false;
            }
        }
    }
}
