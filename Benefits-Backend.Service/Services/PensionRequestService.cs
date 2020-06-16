using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class PensionRequestService : IPensionRequestService
    {
        private readonly IPensionRequestRepository pensionRequestRepository;
        private readonly IMetlifeDataRepository metlifeDataRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IVestingRulesService vestingRulesService;
        private readonly IPensionEnrollmentRulesService pensionEnrollmentRulesService;
        private readonly IAppSettingService appSettingService;
        private readonly IEnumerable<VestingRules> vestingRulesList;
        private readonly IEnumerable<PensionEnrollmentRules> enrollmentRulesList;
        private readonly IRoundDatesService _roundDatesService;

        public PensionRequestService(IPensionRequestRepository pensionRequestRepository,
        IMetlifeDataRepository metlifeDataRepository, 
            IVestingRulesService vestingRulesService, IPensionEnrollmentRulesService pensionEnrollmentRulesService,
            IAppSettingService appSettingService, IEmployeeRepository employeeRepository,IRoundDatesService roundDatesService)

        {
            this.pensionRequestRepository = pensionRequestRepository;
            this.metlifeDataRepository = metlifeDataRepository;
            this.employeeRepository = employeeRepository;

            this.vestingRulesService = vestingRulesService;
            this.pensionEnrollmentRulesService = pensionEnrollmentRulesService;
            this.appSettingService = appSettingService;
            _roundDatesService = roundDatesService;

            vestingRulesList = vestingRulesService.GetVestingRules();
            enrollmentRulesList = pensionEnrollmentRulesService.GetEnrollmentRules();
            appSettingService.GetPensionMaxPercent();



        }
        public PensionRequest CreatePensionRequest(PensionRequest pensionRequest)
        {
            pensionRequestRepository.Add(pensionRequest);
            // if the record added successfully to the database
            // send email for user 
            SendConfirmationEmail(pensionRequest.StaffId,pensionRequest.Name,pensionRequest.WithdrawalAmmount);
            return pensionRequest;
        }

        public bool SendConfirmationEmail(int staffId,string name, decimal withdrawalAmount)
        {
           // staffId = 12345; I'm using this for testing only
            string employeeEmail =  employeeRepository.GetEmployeeEmail(staffId);
            string subject = "Pension Withdrawal Confirmation";
            string body = "Hi "+ name+ ",<br/> You have submitted pension withdrawal request for " + withdrawalAmount + " EGP.<br/> Your request will be approved and processed. <br/> Kindly follow up your request status from tracking option. <br/> Regards, <br/> V-benefits team. <br/>" + DateTime.Now ;
            string from = "vfgroupfunc.mailboxvoisrewardandbenefits@vodafone.com";

            MailMessage message = new MailMessage(from, employeeEmail);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            //  SmtpClient client = new SmtpClient();
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.UseDefaultCredentials = false;
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("vfgroupfunc.mailboxvoisrewardandbenefits@vodafone.com", "Vodafone@1234");
            client.EnableSsl = true;

            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public PensionRequest CalculatePensionFormula(int userStaffId, SuccessFactor successFactorData)
        {
       
            PensionRequest pension = new PensionRequest();
            pension.isEligible = true;
            pension.isEnrolled = true;

            if (this.IsWithdraw(userStaffId))
            {
                pension.isEligible = false;
                return pension;
            } 

          pension.VestingPercent = GetVestingPercent(successFactorData.Band, successFactorData.Tenure);
            if (pension.VestingPercent == -1)
            {
                pension.isEligible = false;
                pension.isEnrolled = false;
                pension.NumberOfMonthsToEnroll = GetNumberOfMonthsToEnroll(successFactorData.Tenure);
                return pension;
            }

            pension = FillPensionObject(userStaffId ,successFactorData , pension);
            return pension;
        }

        public int GetVestingPercent(string band, double tenure)
        {
          
            var enrollmentMonths = enrollmentRulesList.Where(e => e.Band == band).FirstOrDefault().NumberOfMonthsToEnrollment;
            var enrollmentYears = enrollmentMonths / 12.0; 

            var minYear = vestingRulesList.ToList().Min(vr => vr.FromYear);
            var maxYear = vestingRulesList.ToList().Max(vr => vr.FromYear);

            if (tenure < minYear)
            {
                return -1;
            }
            else if(tenure> maxYear)
            {
                return vestingRulesList.Where(x => x.FromYear == maxYear).FirstOrDefault().VestingRulesPercentage;
            }
            else
            {
                return vestingRulesList.Where(x => (x.FromYear + enrollmentYears) < tenure &&
               (x.ToYear + enrollmentYears) > tenure).FirstOrDefault().VestingRulesPercentage;
            }
        }

        public double GetNumberOfMonthsToEnroll(double tenure)
        {
            var minYear = vestingRulesList.ToList().Min(vr => vr.FromYear);
            var noOfMonths = (minYear - tenure) * 12;
            return noOfMonths;
        }

        public decimal CalculateCurrentAvailableBalance(decimal currentContribution, decimal balanceOfLastRound,
            decimal income , decimal withDrawal )
        {
           var proratedContribution=  CalculateProratedContribution(currentContribution);

           var balance = (balanceOfLastRound + income + proratedContribution) - withDrawal;
           return balance;
        }

        public decimal CalculateProratedContribution(decimal contribution)
        {
            var roundDate = _roundDatesService.GetActiveRound();
            var roundStartDate = roundDate.StartDate;
            int year;

            if (roundStartDate.Month > 7)
            {
                year = roundStartDate.Year;
            }
            else
            {
                year = roundStartDate.Year - 1;
            }

            var fixedDate = new DateTime(year, 7, 1);

            var days = roundStartDate - fixedDate;
            var months = days.Days / 30;

            var proratedContribution = (contribution / 12) * months;

            return proratedContribution;
        }
            
        public PensionRequest FillPensionObject(int userStaffId, SuccessFactor successFactorData, PensionRequest pension)
        {
            // pension.Id = userStaffId;
          //  PensionRequest pension = new PensionRequest();
            MetlifeData metlifeData = metlifeDataRepository.GetMetlifeDataForUser(userStaffId);

            // metlife data
            pension.BeginingBalance = metlifeData.OldBalance;
            pension.CurrentyearContribution = metlifeData.Contribution;
            //change the logic from constants to dynamic data
            // pension.CurrentAvailableBalance = metlifeData.NewBalance;
            pension.CurrentAvailableBalance = CalculateCurrentAvailableBalance(metlifeData.Contribution, metlifeData.OldBalance,
               metlifeData.Income, metlifeData.Withdrawals);

            pension.WithdrawalAmmount = metlifeData.Withdrawals;
            pension.LastRoundWithdrawal = metlifeData.Withdrawals;
            pension.Income = metlifeData.Income;
            ///

            /// calculated data 
            pension.VestedBalance = ((pension.VestingPercent * pension.CurrentAvailableBalance) / 100);
            pension.MaxWithdrawalAmount = ((pension.VestedBalance * 65) / 100);
            //change the logic from constants to dynamic data
           // pension.ProratedNewContribution = ((pension.CurrentyearContribution / 12) * 8);
            pension.ProratedNewContribution = CalculateProratedContribution(metlifeData.Contribution);

            ////

            // success factor data 
            pension.StaffId = successFactorData.StaffId;
            pension.Name = successFactorData.Name;
            pension.Band = successFactorData.Band;
            pension.CostCenter = successFactorData.CostCenter;
            pension.Tenure = successFactorData.Tenure;
            //var x = (DateTime.Now - successFactorData.HiringDate);
            //pension.Tenure = x.Days / 365;

            pension.SubBand = successFactorData.SubBand;
            pension.HiringDate = successFactorData.HiringDate;
            ////

            // dummy data related to the request 
            pension.RequestedById = 1;
            pension.RequestedOn = DateTime.Now;
            pension.isActive = true;
            pension.isApproved = false;
            pension.ApprovedOn = DateTime.Now;
            pension.RejectedOn = DateTime.Now;

            return pension;
        }

        public bool IsWithdraw(int userStaffId)
        {
            //If metlifedata last round withdrawal != zero then notEligible 
            MetlifeData metlifeData = metlifeDataRepository.GetMetlifeDataForUser(userStaffId);

            if (metlifeData.Withdrawals != 0){
                return true;
            } else {
                return false;
            }
        }
    }
}
