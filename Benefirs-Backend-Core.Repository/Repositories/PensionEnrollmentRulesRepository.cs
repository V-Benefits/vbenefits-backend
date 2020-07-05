using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend_Core.Repository.Repositories
{
    public class PensionEnrollmentRulesRepository : IPensionEnrollmentRulesRepository
    {
        private readonly ApplicationContext _context;

        public PensionEnrollmentRulesRepository(ApplicationContext context)
        {
            _context = context;
        }
        public ICollection<PensionEnrollmentRules> GetEnrollmentRules()
        {
            return _context.PensionEnrollmentRules.ToList();
        }
    }
}
