using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Repository.UnitOFWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.Repositories
{
    public class SIMCardRequestRepository : ISIMCardRequestRepository
    {
        private readonly ApplicationContext _context;
        public SIMCardRequestRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<string> GetRequestForLookUps()
        {
            var requestForLookups = _context.RequestForLookups.Select(x => x.Value).ToList();
            return requestForLookups;
        }

        public List<string> GetRequestTypes(string requestForValue)
        {
            var requestForId = _context.RequestForLookups.Where(x => x.Value == requestForValue).Select(r => r.Id).FirstOrDefault();
            var requestTypes = _context.RequestTypeLookups.Where(r => r.RequestForId == requestForId).Select(r => r.Value).ToList();
            return requestTypes;
        }

        public async Task Add(SIMCardRequest simCardRequest)
        {
            await _context.SIMCardRequests.AddAsync(simCardRequest);
        }

    }
}
