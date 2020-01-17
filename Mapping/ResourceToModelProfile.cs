using AutoMapper;
using Stream.API.Domain.Models;
using Stream.API.Resources;

namespace Supermarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveResultResource, Result>();
        }
    }
}