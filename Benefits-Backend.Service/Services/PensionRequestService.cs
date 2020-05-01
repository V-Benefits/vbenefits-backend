using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
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


        public PensionRequestService(IPensionRequestRepository pensionRequestRepository, IMetlifeDataRepository metlifeDataRepository, IVestingRulesService vestingRulesService, IPensionEnrollmentRulesService pensionEnrollmentRulesService, IAppSettingService appSettingService)
        {
            this.pensionRequestRepository = pensionRequestRepository;
            this.metlifeDataRepository = metlifeDataRepository;

            this.vestingRulesService = vestingRulesService;
            this.pensionEnrollmentRulesService = pensionEnrollmentRulesService;
            this.appSettingService = appSettingService;
        }
        public PensionRequest CreatePensionRequest(PensionRequest pensionRequest)
        {
            pensionRequestRepository.Add(pensionRequest);
            return pensionRequest;
        }

        public PensionRequest CalculatePensionFormula(int userStaffId, SuccessFactor successFactorData)
        {
            var vestingRules = vestingRulesService.GetVestingRules();
            var enrollmentRules = pensionEnrollmentRulesService.GetEnrollmentRules();
            var maxWithdrawal = appSettingService.GetPensionMaxPercent();

            PensionRequest pension = new PensionRequest();
            MetlifeData metlifeData = metlifeDataRepository.GetMetlifeDataForUser(userStaffId);


            //Check isWithdraw
            if (this.IsWithdraw(userStaffId, successFactorData))
            {
                pension.isEligible = false;
                return pension;
            } else {
                pension.isEligible = true;
            }

            //Check Tenure and Band
            if (successFactorData.Band == "E" || successFactorData.Band == "F")
            {

            }

            pension.Id = userStaffId;
            pension.BeginingBalance = metlifeData.OldBalance;
            pension.CurrentyearContribution = metlifeData.Contribution;
            pension.CurrentAvailableBalance = metlifeData.NewBalance;
            pension.WithdrawalAmmount = metlifeData.Withdrawals;
            //pension.MaxWithdrawalAmount = 

            pension.StaffId = successFactorData.StaffId;
            pension.Name = successFactorData.Name;
            pension.Band = successFactorData.Band;
            pension.CostCenter = successFactorData.CostCenter;
            pension.Tenure = successFactorData.Tenure;
            pension.SubBand = successFactorData.SubBand;
            pension.HiringDate = successFactorData.HiringDate;

            pension.RequestedById = 1;
            pension.RequestedOn = DateTime.Now;
            pension.isActive = true;
            pension.isApproved = false;

            return pension;
        }

        public bool IsWithdraw(int userStaffId, SuccessFactor successFactorData)
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
