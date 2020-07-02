using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
   public interface IMedicalRequestService
    {
        //void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee);
        //void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse);
        void AddMedicalCardRequest(MedicalCardRequest medicalCardRequest);

    }
}
