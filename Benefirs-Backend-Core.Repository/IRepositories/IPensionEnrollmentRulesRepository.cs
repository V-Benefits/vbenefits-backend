using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Repository.IRepositories
{
    public interface IPensionEnrollmentRulesRepository
    {
        ICollection<PensionEnrollmentRules> GetEnrollmentRules();
    }
}
