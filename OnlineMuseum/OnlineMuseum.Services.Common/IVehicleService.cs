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
    public interface IVehicleService
    {
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);

        Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(Paging paging, Sorting sortOrder, Filtering searchVehicle);

        Task InsertVehicleAsync(VehicleModel vehicleModel);

        Task UpdateBaseAsync(IVehicleModel vehicleModel);

        Task DeleteVehicleAsync(Guid id); 

    }
}
