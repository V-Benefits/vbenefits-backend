using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<PensionRequest> GetAllRequests()
        {
           return context.PensionRequests.Where(p=> p.isRejected == false).ToList();
        }

        public void RejectRequest(int staffId)
        {
           var request = context.PensionRequests.Where(p => p.StaffId == staffId).FirstOrDefault();
            request.isRejected = true;
            request.Status = "Rejected";
        }

        //public List<PensionRequest> GetApprovedRequests()
        //{
        //    return context.PensionRequests.Where(p=> p.isApproved == true).ToList();
        //}

        //public int GetApprovedRequestsCount()
        //{
        //    return context.PensionRequests.Where(p => p.isApproved == true).Count();
        //}

        //public List<PensionRequest> GetCanceledRequests()
        //{
        //    return context.PensionRequests.Where(p => p.isCanceled == true).ToList();
        //}

        //public int GetCanceledRequestsCount()
        //{
        //    return context.PensionRequests.Where(p => p.isCanceled == true).Count();
        //}
    }
}
