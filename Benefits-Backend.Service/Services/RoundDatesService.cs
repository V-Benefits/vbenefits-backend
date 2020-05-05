using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Service.Services
{
   public class RoundDatesService : IRoundDatesService
    {
        private readonly IRoundDatesRepository _roundDatesRepository;

        public RoundDatesService(IRoundDatesRepository roundDatesRepository)
        {
            _roundDatesRepository = roundDatesRepository;
        }

        public RoundDate GetActiveRound()
        {
            var roundDate = _roundDatesRepository.GetActiveRound();
            return roundDate;
        }

        public async Task AddRound(RoundDate model)
        {
          await _roundDatesRepository.AddNewRound(model);
        }
    }
}
