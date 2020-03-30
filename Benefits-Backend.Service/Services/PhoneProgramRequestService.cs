using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
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
