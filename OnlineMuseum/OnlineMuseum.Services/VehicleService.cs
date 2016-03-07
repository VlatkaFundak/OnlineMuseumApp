using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using OnlineMuseum.Models;
using OnlineMuseum.Common;
using OnlineMuseum.Repository;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Services.Common;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Services
{
    /// <summary>
    /// Vehicle service class.
    /// </summary>
    public class VehicleService: IVehicleService
    {
        #region Fields

        /// <summary>
        /// Vehicle repository.
        /// </summary>
        private IVehicleRepository vehicleRepository;

        /// <summary>
        /// Category repository.
        /// </summary>
        private ICategoryRepository categoryRepository;

        #endregion

        #region Constructor

        /// <summary>
        /// Vehicle service constructor.
        /// </summary>
        public VehicleService()
        {
            vehicleRepository = new VehicleRepository();
            categoryRepository = new CategoryRepository();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets one vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return await vehicleRepository.GetOneVehicleAsync(id);
        }

        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            return await vehicleRepository.GetVehiclesAsync(paging, filterVehicle, sorting);
        }

        /// <summary>
        /// Inserts new vehicle.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updated database.</returns>
        public Task InsertVehicleAsync(VehicleModelPoco vehicleModel)
        {
            return vehicleRepository.InsertVehicleAsync(vehicleModel);
        }

        /// <summary>
        /// Update database.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updated database.</returns>
        public Task UpdateBaseAsync(IVehicleModel vehicleModel)
        {
            return vehicleRepository.UpdateVehicleAsync(vehicleModel);
        }

        /// <summary>
        /// Deletes vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Updated database.</returns>
        public Task  DeleteVehicleAsync(Guid id)
        {
            return vehicleRepository.DeleteVehicleAsync(id);
        }

        #endregion
    }
}
