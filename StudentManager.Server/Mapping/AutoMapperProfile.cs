using AutoMapper;
using SharedLibrary.Models.Dto;
using SharedLibrary.Models.Entity;

namespace StudentManager.Server.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<CreateStudentDto, Student>().ReverseMap();
            CreateMap<UpdateStudentDto, Student>().ReverseMap();
        }
    }
}
