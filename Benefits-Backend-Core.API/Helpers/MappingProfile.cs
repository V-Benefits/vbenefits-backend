using AutoMapper;
using Benefits_Backend_Core.API.DTO.Employee;
using Benefits_Backend_Core.API.DTO.MedicalRequest;
using Benefits_Backend_Core.API.DTO.MetlifeData;
using Benefits_Backend_Core.API.DTO.PensionRequest;
using Benefits_Backend_Core.API.DTO.PhoneProgramRequest;
using Benefits_Backend_Core.API.DTO.RoundDate;
using Benefits_Backend_Core.Domain.Entities;

namespace Benefits_Backend_Core.API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API DTO to Entity

            CreateMap<EmployeeForAddDTO, Employee>();
            CreateMap<EmployeeForEditDTO, Employee>();

            // Entity to API DTO

            CreateMap<Employee, EmployeeForViewDTO>();
            CreateMap<PhoneProgramRequestForAddDto,PhoneProgramRequest>();
            CreateMap<PensionRequestForAddDto, PensionRequest>();
            CreateMap<MetlifeDataForAddDto, MetlifeData>();

            CreateMap<RoundDateForAddDto, RoundDate>();
            CreateMap<RoundDate, RoundDateForViewDto>();
            CreateMap<EmployeeMedicalRequestForAddDTO, MedicalCardRequestForEmployee>();
            CreateMap<SpouseMedicalRequestForAddDTO, MedicalCardRequestForSpouse>();
        }

    }
}
