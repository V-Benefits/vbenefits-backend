using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
   public interface IPensionRequestService
    {
        PensionRequest CreatePensionRequest(PensionRequest pensionRequest);
        PensionRequest CalculatePensionFormula(int userStaffId, SuccessFactor successFactorData);
        bool IsWithdraw(int userStaffId);
        List<PensionRequest> GetAllRequests();
        void RejectRequest(int staffId);

        //List<PensionRequest> GetApprovedRequests();
        //List<PensionRequest> GetCanceledRequests();
    }
}
