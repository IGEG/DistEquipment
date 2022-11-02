using AutoMapper;
using DistEquipment.Server.ModelDto;
using DistEquipment.Server.Services;
using DistEquipment.Shared;

namespace DistEquipment.Server.Mapper
{
    public class AppMapperProfile:Profile
    {


        public AppMapperProfile()
        {
         
            CreateMap<FeedBackForm, Email>().ForMember(e => e.From, f => f.MapFrom(item => $"{item.Name}"))
            .ForMember(e => e.Subject, f => f.MapFrom(item => $"{item.Name}"))
            .ForMember(e => e.Body, f => f.MapFrom(item => $"{item.Name}"));
            
        }
    }
}
