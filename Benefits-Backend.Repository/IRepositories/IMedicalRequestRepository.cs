using Benefits_Backend.Domain.Entities;


namespace Benefits_Backend.Repository.IRepositories
{
   public interface IMedicalRequestRepository
    {
        //void AddMedicalCardRequestForEmployee(MedicalCardRequestForEmployee medicalCardRequestForEmployee);
        //void AddMedicalCardRequestForSpouse(MedicalCardRequestForSpouse medicalCardRequestForSpouse);
        void AddMedicalCardRequest(MedicalCardRequest medicalCardRequest);
    }
}
