using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.Repositories
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
