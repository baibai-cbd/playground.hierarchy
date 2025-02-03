using AutoMapper;
using playground.hierarchy.Dtos;

namespace playground.hierarchy;

public class hierarchyApplicationAutoMapperProfile : Profile
{
    public hierarchyApplicationAutoMapperProfile()
    {
        CreateMap<ClassA, ClassADto>();
        CreateMap<CreateUpdateClassADto, ClassA>();

        CreateMap<ClassB, ClassBDto>();
        CreateMap<CreateUpdateClassBDto, ClassB>();

        CreateMap<ClassC, ClassCDto>();
        CreateMap<CreateUpdateClassCDto, ClassC>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
