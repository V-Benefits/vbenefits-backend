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
        private readonly IPensionEnrollmentRulesRepository enrollmentRulesRepository;

        public ICollection<PensionEnrollmentRules> GetEnrollmentRules()
        {
            return this.enrollmentRulesRepository.GetEnrollmentRules();
        }
    }
}
