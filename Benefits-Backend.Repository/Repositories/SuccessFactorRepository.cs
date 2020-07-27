using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Repository.Repositories
{
   public class SuccessFactorRepository : ISuccessFactorRepository
    {
        private readonly ApplicationContext _context;
        public SuccessFactorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public SuccessFactor GetEmpolyeeSuccessFactorObject(int staffId)
        {
            var successFactor = _context.SuccessFactor.Where(x => x.StaffId == staffId).SingleOrDefault();
            return successFactor;
        }

        public string GetEmpolyeeSuccessFactorBand(int staffId)
        {
            var employeeBand = _context.SuccessFactor.Where(x => x.StaffId == staffId).SingleOrDefault().Band;
            return employeeBand;
        }
    }
}
