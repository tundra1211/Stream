using AutoMapper;
using Stream.API.Domain.Models;
using Stream.API.Resources;

namespace Stream.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Result, ResultResource>();
            CreateMap<Result, SaveResponseResource>();
            CreateMap<Student, StudentResource>();
        }
    }
}