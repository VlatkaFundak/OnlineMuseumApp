using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq.Dynamic;
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

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(Paging paging, Sorting sortOrder, Filtering searchVehicle)
        {
            return await vehicleContext.VehicleModels
                .Where(item => String.IsNullOrEmpty(searchVehicle.SearchVehicle) ? item != null : item.Name.Contains(searchVehicle.SearchVehicle))
                .OrderBy(sortOrder.SortOrder)
                .ToPagedListAsync(paging.PageNumber,paging.PageSize);
        }

        public async Task InsertVehicleAsync(VehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);

            vehicleContext.VehicleModels.Add(vehicleModel);
            await vehicleContext.SaveChangesAsync();

        }

        public async Task UpdateVehicleAsync(IVehicleModel vehicle)
        {
            await vehicleContext.SaveChangesAsync(); 
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
