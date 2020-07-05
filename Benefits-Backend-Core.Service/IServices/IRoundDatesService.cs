using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Service.IServices
{
   public interface IRoundDatesService
    {
        RoundDate GetActiveRound();
        Task AddRound(RoundDate model);
    }
}
