using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface IPensionEnrollmentRulesRepository
    {
        ICollection<PensionEnrollmentRules> GetEnrollmentRules();
    }
}
