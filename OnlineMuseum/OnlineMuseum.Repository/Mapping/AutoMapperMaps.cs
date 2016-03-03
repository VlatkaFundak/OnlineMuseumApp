using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

namespace OnlineMuseum.Repository.Mapping
{
    public static class AutoMapperMaps
    {
        private static IMapper mapper = null;

        public static IMapper GetMapper()
        {
            return mapper;
        }

        public static void ConfigureMapping()
        {
            var config = new MapperConfiguration(cfg =>
                { 
                    cfg.AddProfile<Mappings>();
                });

             mapper = config.CreateMapper();
        }

    }
}
