using Benefits_Backend_Core.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Benefits_Backend_Core.Repository.IRepositories
{
    public interface IVestingRulesRepository
    {
        List<VestingRules> GetVestingRules();
    }
}
