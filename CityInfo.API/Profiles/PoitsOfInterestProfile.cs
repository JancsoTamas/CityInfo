using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Profiles
{
    public class PointsOfInterestProfile : Profile
    {
        public PointsOfInterestProfile()
        {
            CreateMap<Entities.PointsOfInterest, Models.PointsOfInterestDto>();
            CreateMap<Models.PointsOfInterestForCreationDto, Entities.PointsOfInterest>();
            CreateMap<Models.PointsOfInterestForUpdateDto, Entities.PointsOfInterest>();
        }
    }
}
