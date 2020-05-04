using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class PensionEnrollmentRulesService : IPensionEnrollmentRulesService
    {
        private readonly IPensionEnrollmentRulesRepository _enrollmentRulesRepository;

        public PensionEnrollmentRulesService(IPensionEnrollmentRulesRepository enrollmentRulesRepository)
        {
            _enrollmentRulesRepository = enrollmentRulesRepository;
        }
        public ICollection<PensionEnrollmentRules> GetEnrollmentRules()
        {
            return this._enrollmentRulesRepository.GetEnrollmentRules();
        }
    }
}
