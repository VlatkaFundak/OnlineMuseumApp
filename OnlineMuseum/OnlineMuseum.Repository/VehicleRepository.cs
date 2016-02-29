using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq.Dynamic;

using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Common;
using OnlineMuseum.DAL;
using OnlineMuseum.Models;

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
            try
            {
                return await vehicleContext.VehicleModels.FindAsync(id);
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync()
        {
            try
            {
                return await vehicleContext.VehicleModels.ToListAsync();
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesInCategory(Guid id)
        {
            return await vehicleContext.VehicleModels.Where(item => item.VehicleCategoryId == id).ToListAsync();
        }

        public async Task NewVehicleAsync(VehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Abrv.Substring(0, 3);

            try
            {
                vehicleContext.VehicleModels.Add(vehicleModel);
                await vehicleContext.SaveChangesAsync();
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        public async Task UpdateBaseAsync()
        {
            try
            {
                await vehicleContext.SaveChangesAsync();
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        public async Task DeleteVehicleAsync(Guid id)
        {
            try
            {
                VehicleModel oneVehicle = await vehicleContext.VehicleModels.FindAsync(id);
                vehicleContext.VehicleModels.Remove(oneVehicle);
                await vehicleContext.SaveChangesAsync();
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return await vehicleContext.VehicleCategories.ToListAsync();
        }

        public async Task<IVehicleCategory> GetOneCategory(Guid id)
        {
            return await vehicleContext.VehicleCategories.FindAsync(id);
        }

        #endregion
    }
}
