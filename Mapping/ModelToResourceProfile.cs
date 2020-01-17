using AutoMapper;
using Stream.API.Domain.Models;
using Stream.API.Resources;

namespace Supermarket.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Result, ResultResource>();
        }
    }
}