using AutoMapper;
using Benefits_Backend.API.DTO.Employee;
using Benefits_Backend.API.DTO.PensionRequest;
using Benefits_Backend.API.DTO.PhoneProgramRequest;
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

            // Entity to API DTO

            CreateMap<Employee, EmployeeForViewDTO>();

            CreateMap<PhoneProgramRequestForAddDto,PhoneProgramRequest>();

            CreateMap<PensionRequestForAddDto, PensionRequest>();

        }

    }
}
