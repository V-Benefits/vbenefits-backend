using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Repository.Repositories
{
    public class PensionEnrollmentRulesRepository : IPensionEnrollmentRulesRepository
    {
        private readonly ApplicationContext context;
        public ICollection<PensionEnrollmentRules> GetEnrollmentRules()
        {
            return context.PensionEnrollmentRules.ToList();
        }
    }
}
