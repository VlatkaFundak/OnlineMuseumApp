using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList.EntityFramework;

using OnlineMuseum.DAL;
using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Repository
{
    /// <summary>
    /// Vehicle repository class.
    /// </summary>
    public class VehicleRepository: IVehicleRepository
    {
        #region Fields

        /// <summary>
        /// Vehicle context field.
        /// </summary>
        private VehicleContext vehicleContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Vehicle repository constructor.
        /// </summary>
        public VehicleRepository()
        {
            vehicleContext = new VehicleContext();        
        }

        #endregion

        #region Methods

        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return await vehicleContext.VehicleModels.FindAsync(id);
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(IPagingParameters paging, IVehicleFilter searchVehicle)
        {
            return await  vehicleContext.VehicleModels
                .Where(item => Guid.Empty == searchVehicle.CategoryId ? item != null : item.VehicleCategoryId == searchVehicle.CategoryId)
                .OrderBy(item => item.Name)
                .ToPagedListAsync(paging.PageNumber,paging.PageSize);

        }

        public async Task InsertVehicleAsync(VehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);

            vehicleContext.VehicleModels.Add(vehicleModel);
            await vehicleContext.SaveChangesAsync();

        }

        public Task UpdateVehicleAsync(IVehicleModel vehicle)
        {
            return vehicleContext.SaveChangesAsync(); 
        }

        public async Task DeleteVehicleAsync(Guid id)
        {
            VehicleModel oneVehicle = await vehicleContext.VehicleModels.FindAsync(id);
            vehicleContext.VehicleModels.Remove(oneVehicle);
            await vehicleContext.SaveChangesAsync();

        }

        #endregion
    }
}
