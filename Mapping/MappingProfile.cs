using AutoMapper;
using netcoreplayground.Controllers.Resources;
using netcoreplayground.Models;

namespace netcoreplayground.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}