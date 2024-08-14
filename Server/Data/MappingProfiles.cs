using AutoMapper;
using PepsiCoProjectTimeline.Server.Data.Entities;
using PepsiCoProjectTimeline.Shared.Models;

namespace PepsiCoProjectTimeline.Server.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectTimeline, ProjectTimelineModel>().ReverseMap();
        }
    }
}