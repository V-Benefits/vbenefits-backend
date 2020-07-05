using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.IRepositories
{
    public interface IPhoneProgramRequestRepository
    {
        Task<PhoneProgramRequest> Add(PhoneProgramRequest phoneProgramRequest);
    }
}
