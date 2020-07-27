using AutoMapper;
using Benefits_Backend.API.DTO.Employee;
using Benefits_Backend.API.DTO.MedicalRequest;
using Benefits_Backend.API.DTO.MetlifeData;
using Benefits_Backend.API.DTO.PensionRequest;
using Benefits_Backend.API.DTO.PhoneProgramRequest;
using Benefits_Backend.API.DTO.RoundDate;
using Benefits_Backend.API.DTO.SIMCardRequest;
using Benefits_Backend.Domain.Entities;

namespace Benefits_Backend.API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API DTO to Entity
            CreateMap<EmployeeForAddDTO, Employee>();
            CreateMap<EmployeeForEditDTO, Employee>();

            CreateMap<PhoneProgramRequestForAddDto, PhoneProgramRequest>();
            CreateMap<PensionRequestForAddDto, PensionRequest>();
            CreateMap<MetlifeDataForAddDto, MetlifeData>();
            CreateMap<RoundDateForAddDto, RoundDate>();

            CreateMap<EmployeeMedicalRequestForAddDTO, MedicalCardRequestForEmployee>();
            CreateMap<SpouseMedicalRequestForAddDTO, MedicalCardRequestForSpouse>();
            CreateMap<MedicalRequestForAddDTO, MedicalCardRequest>();
            CreateMap<ChildrenInfoDTO, MedicalCardRequest>();

            CreateMap<SimCardRequestForAddDto, SIMCardRequest>();

            // Entity to API DTO
            CreateMap<Employee, EmployeeForViewDTO>();
            CreateMap<PensionRequest, PensionRequestDTO>();
            CreateMap<RoundDate, RoundDateForViewDto>();
            CreateMap<RequestForLookup, RequestForLookUpForViewDTO>();
        }

    }
}
