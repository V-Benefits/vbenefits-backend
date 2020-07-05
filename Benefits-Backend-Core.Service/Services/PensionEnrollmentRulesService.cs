using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using Benefits_Backend_Core.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.Services
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
