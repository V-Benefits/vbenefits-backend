using Benefits_Backend.Service.IServices;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;

namespace Benefits_Backend.Service.Services
{
   public class MedicalRequestService : IMedicalRequestService
    {
        private readonly IMedicalRequestRepository medicalRequestRepository;
        public MedicalRequestService(IMedicalRequestRepository medicalRequestRepository)
        {
            this.medicalRequestRepository = medicalRequestRepository;
        }

        public void AddMedicalCardRequest(MedicalCardRequest medicalCardRequest)
        {
            medicalRequestRepository.AddMedicalCardRequest(medicalCardRequest);
        }

        //public void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee)
        //{
        //    medicalRequestRepository.AddMedicalCardRequestForEmployee(medicalCardRequestForEmployee);
        //}

        //public void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse)
        //{
        //    medicalRequestRepository.AddMedicalCardRequestForSpouse(medicalCardRequestForSpouse);
        //}
    }
}
