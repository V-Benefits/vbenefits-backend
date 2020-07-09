using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Repository.Repositories
{
    public class PensionAdminRepository : IPensionAdminRepository
    {
        private readonly ApplicationContext context;

        public PensionAdminRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void UpdatePensionUserInterface(RoundDate firstRound, RoundDate secondRound, string pensionPolicyURL, string pensionPolicyFilePath)
        {
            var DBpensionPolicyURL = context.URLsLookups.Where(p => p.Key == "PensionPolicyURL").FirstOrDefault();
            DBpensionPolicyURL.Value = pensionPolicyURL;

            var DBpensionPolicyFilePath = context.URLsLookups.Where(p => p.Key == "PensionPolicyFilePath").FirstOrDefault();
            DBpensionPolicyFilePath.Value = pensionPolicyFilePath;

            var DBfirstRound = context.RoundDates.Where(r => r.RoundName == "FirstRound").FirstOrDefault();
            DBfirstRound.StartDate = firstRound.StartDate;
            DBfirstRound.EndDate = firstRound.EndDate;
            var DBsecondRound = context.RoundDates.Where(r => r.RoundName == "SecondRound").FirstOrDefault();
            DBsecondRound.StartDate = secondRound.StartDate;
            DBsecondRound.EndDate = secondRound.EndDate;

        }
    }
}
