using AutoMapper;
using VNZWalks.API.Models.Domain;
using VNZWalks.API.Models.Dto;

namespace VNZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Region, RegionsDto>();
        }
    }
}
