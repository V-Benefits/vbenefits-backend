using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.IServices
{
   public interface IPensionRequestService
    {
        PensionRequest CreatePensionRequest(PensionRequest pensionRequest);
        PensionRequest CalculatePensionFormula(int userStaffId, SuccessFactor successFactorData);
        bool IsWithdraw(int userStaffId);
    }
}
