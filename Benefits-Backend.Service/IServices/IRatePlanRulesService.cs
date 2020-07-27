using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
    public interface IRatePlanRulesService
    {
        string GetEmployeeEligibileRatePlan(string band);
    }
}
