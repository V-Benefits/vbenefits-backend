using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface ISIMCardRequestRepository
    {
        List<string> GetRequestForLookUps();
        List<string> GetRequestTypes(string requestForValue);
        Task Add(SIMCardRequest simCardRequest);
    }
}
