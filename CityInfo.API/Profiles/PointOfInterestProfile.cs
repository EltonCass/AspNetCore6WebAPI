using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForUpsertDto, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpsertDto>();
        }
    }
}
