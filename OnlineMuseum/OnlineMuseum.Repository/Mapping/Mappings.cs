using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.DAL.Entities;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;

using AutoMapper;

namespace OnlineMuseum.Repository.Mapping
{
    public class Mappings: Profile
    {
        protected override void Configure()
        {
            CreateMap<VehicleModel, VehicleModelPoco>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelPoco>().ReverseMap();

            CreateMap<VehicleMaker, VehicleMakerPoco>().ReverseMap();
            CreateMap<VehicleMaker, IVehicleMaker>().ReverseMap();
            CreateMap<IVehicleMaker, VehicleMakerPoco>().ReverseMap();

            CreateMap<VehicleCategory, VehicleCategoryPoco>().ReverseMap();
            CreateMap<VehicleCategory, IVehicleCategory>().ReverseMap();
            CreateMap<IVehicleCategory, VehicleCategoryPoco>().ReverseMap();
        }
    }
}
