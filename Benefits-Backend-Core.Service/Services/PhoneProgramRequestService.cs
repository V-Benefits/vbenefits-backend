using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using Benefits_Backend_Core.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.Services
{
    public class PhoneProgramRequestService : IPhoneProgramRequestService
    {
        private readonly IPhoneProgramRequestRepository phoneProgramRequestRepository;

        public PhoneProgramRequestService(IPhoneProgramRequestRepository phoneProgramRequestRepository)
        {
            this.phoneProgramRequestRepository = phoneProgramRequestRepository;
        }

        public PhoneProgramRequest CreatePhoneProgramRequest(PhoneProgramRequest phoneProgramRequest)
        {
            phoneProgramRequestRepository.Add(phoneProgramRequest);
            return phoneProgramRequest;
        }
    }
}
