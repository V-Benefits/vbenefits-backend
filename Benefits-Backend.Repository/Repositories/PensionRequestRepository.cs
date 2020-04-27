using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.Repositories
{
    public class PensionRequestRepository : IPensionRequestRepository
    {
        private readonly ApplicationContext context;

        public PensionRequestRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<PensionRequest> Add(PensionRequest pensionRequest)
        {
           await context.PensionRequests.AddAsync(pensionRequest);
            return pensionRequest;
        }
    }
}
