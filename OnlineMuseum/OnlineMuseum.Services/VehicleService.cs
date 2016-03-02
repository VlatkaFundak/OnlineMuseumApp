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

        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return await vehicleRepository.GetOneVehicleAsync(id);
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(IPagingParameters paging,  IVehicleFilter searchVehicle)
        {
            return await vehicleRepository.GetAllVehiclesAsync(paging, searchVehicle);
        }

        public async Task InsertVehicleAsync(VehicleModel vehicleModel)
        {
            await vehicleRepository.InsertVehicleAsync(vehicleModel);
        }

        public async Task UpdateBaseAsync(IVehicleModel vehicleModel)
        {
            await vehicleRepository.UpdateVehicleAsync(vehicleModel);
        }

        public Task  DeleteVehicleAsync(Guid id)
        {
            return vehicleRepository.DeleteVehicleAsync(id);
        }

    }
}
