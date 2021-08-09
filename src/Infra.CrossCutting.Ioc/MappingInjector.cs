using Presentation.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.CrossCutting.Ioc
{
    public static class MappingInjector
    {
        public static void AddMappingForApplication()
        {
            ConfigureMap.Configure();
        }
    }
}
