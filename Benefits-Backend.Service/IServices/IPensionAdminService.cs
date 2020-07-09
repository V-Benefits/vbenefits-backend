using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
   public interface IPensionAdminService
    {
        void UpdatePensionUserInterface(RoundDate firstRound, RoundDate secondRound, string pensionPolicyURL, string pensionPolicyFilePath);

    }
}
