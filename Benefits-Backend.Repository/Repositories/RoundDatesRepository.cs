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
   public class RoundDatesRepository : IRoundDatesRepository
    {
        private readonly ApplicationContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public RoundDatesRepository(ApplicationContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public RoundDate GetActiveRound()
        {
           var round=  _context.RoundDates.Where(x => x.IsActive == true).SingleOrDefault();
           return round;
        }

        public async Task AddNewRound(RoundDate model)
        {
          await  _context.RoundDates.AddAsync(model);
          await _unitOfWork.Commit();
        }
    }
}
