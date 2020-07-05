using System;
using System.Collections.Generic;
using System.Text;
using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;

namespace Benefits_Backend_Core.Repository.Repositories
{
    public class MedicalRequestRepository : IMedicalRequestRepository
    {
        private readonly ApplicationContext context;

        public MedicalRequestRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee)
        {
            context.medicalCardRequestForEmployees.Add(medicalCardRequestForEmployee);
        }

        public void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse)
        {
            context.medicalCardRequestForSpouses.Add(medicalCardRequestForSpouse);
        }
    }
}