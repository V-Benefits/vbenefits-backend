using AutoMapper;
using Benefits_Backend.API.DTO.Employee;
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
         
         

        }

    }
}
