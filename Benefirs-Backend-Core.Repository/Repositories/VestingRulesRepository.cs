using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend_Core.Repository.Repositories
{
    public class VestingRulesRepository : IVestingRulesRepository
    {
        private readonly ApplicationContext context;

        public VestingRulesRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public List<VestingRules> GetVestingRules()
        {
            return context.VestingRules.ToList();
        }
    }
}
