using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
    public interface IVestingRulesService
    {
        ICollection<VestingRules> GetVestingRules();
    }
}
