using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.IServices
{
   public interface IMedicalRequestService
    {
        void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee);
        void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse);
    }
}
