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
    /// <summary>
    /// Maker repository class.
    /// </summary>
    public class MakerRepository: IMakerRepository
    {
        #region Fields

        /// <summary>
        /// Vehicle context field.
        /// </summary>
        private VehicleContext vehicleContext;

        /// <summary>
        /// Mapper.
        /// </summary>
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

        /// <summary>
        /// Gets all makers.
        /// </summary>
        /// <returns>Makers.</returns>
        public async Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync()
        {
            return mapper.Map<IEnumerable<VehicleMakerPoco>>(await vehicleContext.VehicleMakers.ToListAsync());
        }

        /// <summary>
        /// Gets one maker.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Maker.</returns>
        public async Task<IVehicleMaker> GetOneMakerAsync(Guid id)
        {
            return mapper.Map<VehicleMakerPoco>(await vehicleContext.VehicleMakers.FindAsync(id));
        }
    }
}
