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
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);

        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle);

        Task InsertVehicleAsync(IVehicleModel vehicleModel);

        Task UpdateVehicleAsync(IVehicleModel vehicleModel);

        Task DeleteVehicleAsync(Guid id);
    }
}
