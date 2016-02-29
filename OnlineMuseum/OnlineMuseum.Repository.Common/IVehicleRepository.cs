﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Models;

namespace OnlineMuseum.Repository.Common
{
    /// <summary>
    /// Vehicle repository interface.
    /// </summary>
    public interface IVehicleRepository
    {
        Task<IVehicleModel> GetOneVehicleAsync(Guid id);

        Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync();

        Task<IEnumerable<IVehicleModel>> GetAllVehiclesInCategory(Guid id);

        Task NewVehicleAsync(VehicleModel vehicleModel);

        Task UpdateBaseAsync();

        Task DeleteVehicleAsync(Guid id);

        Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync();

        Task<IVehicleCategory> GetOneCategory(Guid id);

    }
}