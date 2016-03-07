using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Common;

namespace OnlineMuseum.Repository.Common
{
    /// <summary>
    /// Vehicle repository interface.
    /// </summary>
    public interface IVehicleRepository
    {
        /// <summary>
        /// Gets one vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);


        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting);

        /// <summary>
        /// Instert new vehicle.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updates database.</returns>
        Task InsertVehicleAsync(IVehicleModel vehicleModel);

        /// <summary>
        /// Upade vehicles.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updates database.</returns>
        Task UpdateVehicleAsync(IVehicleModel vehicleModel);

        /// <summary>
        /// Delete vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Updated base.</returns>
        Task DeleteVehicleAsync(Guid id);
    }
}
