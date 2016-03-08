using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models;
using OnlineMuseum.Common;
using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Services.Common
{
    /// <summary>
    /// Vehicle service interface.
    /// </summary>
    public interface IVehicleService
    {
        /// <summary>
        /// Gets one vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);

        /// <summary>
        /// Gets vehicles.
        /// </summary>
        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>
        /// <returns>Vehicles.</returns>
        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting);

        /// <summary>
        /// Inserts new vehicle.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updated database.</returns>
        Task InsertVehicleAsync(VehicleModelPoco vehicleModel);

        /// <summary>
        /// Update database.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updated database.</returns>
        Task UpdateBaseAsync(IVehicleModel vehicleModel);

        /// <summary>
        /// Deletes vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Updated database.</returns>
        Task DeleteVehicleAsync(Guid id);
    }
}
