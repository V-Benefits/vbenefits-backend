using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.Repositories
{
    public class RatePlanRulesRepository : IRatePlanRulesRepository
    {
        private readonly ApplicationContext _context;

        public RatePlanRulesRepository(ApplicationContext context)
        {
            _context = context;
        }

        //public async Task<string> GetEmployeeRatePlan(string band)
        //{
        //    var employeeRatePlan =await _context.RatePlanRules.Where(r => r.Band == band).FirstOrDefaultAsync();
        //    return employeeRatePlan.RatePlan;
        //}

        public string GetEmployeeRatePlan(string band)
        {
            var employeeRatePlan = _context.RatePlanRules.Where(r => r.Band == band).FirstOrDefault();
            return employeeRatePlan.RatePlan;
        }

        public List<string> GetRatePlans(string band, string requestType)
        {
            var defaultRatePlan = new RatePlanRules();

            if (requestType == "New Data SIM" || requestType == "Change Your Data SIM")
                defaultRatePlan = _context.RatePlanRules.Where(r => r.Band == band && r.BundleType == "Employee Data").FirstOrDefault();

            else
                defaultRatePlan = _context.RatePlanRules.Where(r => r.Band == band && r.BundleType == "Employee Line").FirstOrDefault();

            var ratePlans = _context.RatePlanRules.Where(r => (r.Band == band || r.Number > defaultRatePlan.Number) &&  r.BundleType == defaultRatePlan.BundleType).Select(r => r.RatePlan).ToList();
            return ratePlans;
        }
    }
}
