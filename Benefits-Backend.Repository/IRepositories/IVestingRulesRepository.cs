using Benefits_Backend.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface IVestingRulesRepository
    {
        List<VestingRules> GetVestingRules();
    }
}
