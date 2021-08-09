using AutoMapper;

namespace Presentation.Mapping
{
    public static class ConfigureMap
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DataMappingProfile>();
            });
        }
    }
}
