using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Common;

namespace OnlineMuseum.Repository.Common
{
    /// <summary>
    /// Vehicle repository interface.
    /// </summary>
    public interface IVehicleRepository
    {
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);

        Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(IPagingParameters paging, IVehicleFilter searchVehicle);

        Task InsertVehicleAsync(VehicleModel vehicleModel);

        Task UpdateVehicleAsync(IVehicleModel vehicleModel);

        Task DeleteVehicleAsync(Guid id);
    }
}
