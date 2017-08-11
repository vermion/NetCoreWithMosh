using AutoMapper;
using NetCoreWithMosh.Controllers.Resources;
using NetCoreWithMosh.Models;

namespace NetCoreWithMosh.Mapping
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
