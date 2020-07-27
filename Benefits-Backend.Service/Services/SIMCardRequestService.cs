using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Repository.UnitOFWork;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Service.Services
{
   public class SIMCardRequestService : ISIMCardRequestService
    {
        private readonly ISIMCardRequestRepository _simCardRequestRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ISuccessFactorRepository _successFactorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRatePlanRulesRepository _ratePlanRulesRepository;

        public SIMCardRequestService(ISIMCardRequestRepository simCardRequestRepository,
            IEmployeeRepository employeeRepository,
            ISuccessFactorRepository successFactorRepository,
            IUnitOfWork unitOfWork,
            IRatePlanRulesRepository ratePlanRulesRepository)
        {
            _simCardRequestRepository = simCardRequestRepository;
            _employeeRepository = employeeRepository;
            _successFactorRepository = successFactorRepository;
            _unitOfWork = unitOfWork;
            _ratePlanRulesRepository = ratePlanRulesRepository;
        }

        public int GetEmployeeNumberOfUsedLines(int staffId)
        {
            var numberOfUsedLines = _employeeRepository.GetEmployeeNumberOfUsedLines(staffId);
            return numberOfUsedLines;
        }

        public string GetEmployeeBand(int staffId)
        {
            var band = _successFactorRepository.GetEmpolyeeSuccessFactorBand(staffId);
            return band;
        }

        public List<string> GetRequestForLookUps()
        {
            var requestForLookups = _simCardRequestRepository.GetRequestForLookUps();
            return requestForLookups;
        }

        public List<string> GetRequestTypes(string requestForValue)
        {
            var requestTypes = _simCardRequestRepository.GetRequestTypes(requestForValue);
            return requestTypes;
        }

        public async Task CreateSimCardRequest(SIMCardRequest simCardRequest)
        {
           await _simCardRequestRepository.Add(simCardRequest);
           await _unitOfWork.Commit();
        }

        public List<string> GetRatePlansForBand(string band)
        {
            var ratePlans = _ratePlanRulesRepository.GetRatePlans(band);
            return ratePlans;
        }
    }
}
