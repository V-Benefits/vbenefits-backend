using Benefits_Backend_Core.Domain.Entities;


namespace Benefits_Backend_Core.Repository.IRepositories
{
   public interface IMedicalRequestRepository
    {
        void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee);
        void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse);
    }
}
