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

        public PensionRequestService(IPensionRequestRepository pensionRequestRepository)
        {
            this.pensionRequestRepository = pensionRequestRepository;
        }
        public PensionRequest CreatePensionRequest(PensionRequest pensionRequest)
        {
            pensionRequestRepository.Add(pensionRequest);
            return pensionRequest;
        }
    }
}
