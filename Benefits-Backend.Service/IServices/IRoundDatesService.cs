using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Service.IServices
{
   public interface IRoundDatesService
    {
        RoundDate GetActiveRound();
        Task AddRound(RoundDate model);
    }
}
