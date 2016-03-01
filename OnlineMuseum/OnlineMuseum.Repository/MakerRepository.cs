using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using OnlineMuseum.DAL;
using OnlineMuseum.Models.Common;
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

        #endregion

        #region Constructor

        /// <summary>
        /// Maker repository constructor.
        /// </summary>
        public MakerRepository()
        {
            vehicleContext = new VehicleContext();        
        }

        #endregion

        public async Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync()
        {
            return await vehicleContext.VehicleMakers.ToListAsync();
        }

        public async Task<IVehicleMaker> GetOneMakerAsync(Guid id)
        {
            return await vehicleContext.VehicleMakers.FindAsync(id);
        }
    }
}
