using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

using OnlineMuseum.DAL;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Mapping;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Repository
{
    public class MakerRepository: IMakerRepository
    {
        #region Fields

        /// <summary>
        /// Vehicle context field.
        /// </summary>
        private VehicleContext vehicleContext;
        private IMapper mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Maker repository constructor.
        /// </summary>
        public MakerRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        public async Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync()
        {
            return mapper.Map<IEnumerable<VehicleMakerPoco>>(await vehicleContext.VehicleMakers.ToListAsync());
        }

        public async Task<IVehicleMaker> GetOneMakerAsync(Guid id)
        {
            return mapper.Map<VehicleMakerPoco>(await vehicleContext.VehicleMakers.FindAsync(id));
        }
    }
}
