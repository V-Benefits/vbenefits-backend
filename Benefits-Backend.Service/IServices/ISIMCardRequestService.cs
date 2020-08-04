using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Service.IServices
{
    public interface ISIMCardRequestService
    {
        int GetEmployeeNumberOfUsedLines(int staffId);

        string GetEmployeeBand(int staffId);

        List<string> GetRequestForLookUps();

        List<string> GetRequestTypes(string requestForId);

        Task CreateSimCardRequest(SIMCardRequest simCardRequest);

        List<string> GetRatePlansForBand(string band, string requestType);
    }
}
