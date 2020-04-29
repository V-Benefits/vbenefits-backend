using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class VestingRulesService : IVestingRulesService
    {
        private readonly IVestingRulesRepository _vestingRulesRepository;

        public VestingRulesService(IVestingRulesRepository vestingRulesRepository)
        {
            _vestingRulesRepository = vestingRulesRepository;
        }

        public ICollection<VestingRules> GetVestingRules()
        {
            return this._vestingRulesRepository.GetVestingRules();
        }
    }
}
