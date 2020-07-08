using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
   public interface IPensionRequestRepository
    {
        Task<PensionRequest> Add(PensionRequest pensionRequest);
        List<PensionRequest> GetAllRequests();
        void RejectRequest(int staffId);
        //List<PensionRequest> GetApprovedRequests();
        //List<PensionRequest> GetCanceledRequests();
        //int GetApprovedRequestsCount();
        //int GetCanceledRequestsCount();

    }
}
