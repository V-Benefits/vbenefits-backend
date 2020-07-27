using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class RatePlanRulesService : IRatePlanRulesService
    {
        private readonly IRatePlanRulesRepository _ratePlanRulesRepository;

        public RatePlanRulesService(IRatePlanRulesRepository ratePlanRulesRepository)
        {
            _ratePlanRulesRepository = ratePlanRulesRepository;
        }
        public string GetEmployeeEligibileRatePlan(string band)
        {
            var employeeRatePlan = _ratePlanRulesRepository.GetEmployeeRatePlan(band);
            return employeeRatePlan;
        }
    }
}
