using Benefits_Backend.API.Controllers;
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

        public PensionRequestService(IPensionRequestRepository pensionRequestRepository, IMetlifeDataRepository metlifeDataRepository)
        {
            this.pensionRequestRepository = pensionRequestRepository;
            this.metlifeDataRepository = metlifeDataRepository;
        }
        public PensionRequest CreatePensionRequest(PensionRequest pensionRequest)
        {
            pensionRequestRepository.Add(pensionRequest);
            return pensionRequest;
        }

        public PensionRequest CalculatePensionFormula(int userStaffId , SuccessFactor successFactorData)
        {
            PensionRequest pension = new PensionRequest();
            MetlifeData metlifeData =  metlifeDataRepository.GetMetlifeDataForUser(userStaffId);
            pension.Id = userStaffId;
            pension.BeginingBalance = metlifeData.OldBalance ;
            pension.CurrentyearContribution = metlifeData.Contribution ;
            pension.CurrentAvailableBalance = metlifeData.NewBalance;
            pension.WithdrawalAmmount = metlifeData.Withdrawals;
               
            return pension;
        }
    }
}
