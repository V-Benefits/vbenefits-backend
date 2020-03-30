using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface IPhoneProgramRequestRepository
    {
        Task<PhoneProgramRequest> Add(PhoneProgramRequest phoneProgramRequest);
    }
}
