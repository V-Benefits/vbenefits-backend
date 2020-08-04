using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
   public interface IRatePlanRulesRepository
    {
        //Task<string> GetEmployeeRatePlan(string band);
        string GetEmployeeRatePlan(string band);

        List<string> GetRatePlans(string band, string requestType);
    }
}
