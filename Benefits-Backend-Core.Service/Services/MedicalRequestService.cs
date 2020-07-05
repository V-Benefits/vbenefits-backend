using Benefits_Backend_Core.Service.IServices;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;

namespace Benefits_Backend_Core.Service.Services
{
   public class MedicalRequestService : IMedicalRequestService
    {
        private readonly IMedicalRequestRepository medicalRequestRepository;
        public MedicalRequestService(IMedicalRequestRepository medicalRequestRepository)
        {
            this.medicalRequestRepository = medicalRequestRepository;
        }

        public void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee)
        {
            medicalRequestRepository.AddMedicalCardRequestForEmployee(medicalCardRequestForEmployee);
        }

        public void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse)
        {
            medicalRequestRepository.AddMedicalCardRequestForSpouse(medicalCardRequestForSpouse);
        }
    }
}
