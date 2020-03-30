using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.Repositories
{
   public class PhoneProgramRequestRepository : IPhoneProgramRequestRepository
    {
        private readonly ApplicationContext context;

        public PhoneProgramRequestRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<PhoneProgramRequest> Add(PhoneProgramRequest phoneProgramRequest)
        {
            await context.PhoneProgramRequests.AddAsync(phoneProgramRequest);
            return phoneProgramRequest;
        }
    }
}
