using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class PensionAdminService : IPensionAdminService
    {
        private readonly IPensionAdminRepository pensionAdminRepository;

        public PensionAdminService(IPensionAdminRepository pensionAdminRepository)
        {
            this.pensionAdminRepository = pensionAdminRepository;      
        }

        public void UpdatePensionUserInterface(RoundDate firstRound, RoundDate secondRound, string pensionPolicyURL, string pensionPolicyFilePath)
        {
            pensionAdminRepository.UpdatePensionUserInterface(firstRound, secondRound, pensionPolicyURL, pensionPolicyFilePath);
        }
    }
}
