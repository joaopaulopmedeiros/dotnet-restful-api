using AutoMapper;
using Domain;
using Presentation.Views;

namespace Presentation.Mapping
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<News, NewsView>().ReverseMap();
        }
    }
}
