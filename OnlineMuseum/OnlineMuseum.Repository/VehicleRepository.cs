using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList.EntityFramework;
using AutoMapper;

using OnlineMuseum.DAL;
using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Common;
using OnlineMuseum.Repository.Mapping;

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
        private IMapper mapper;

        #endregion

        #region Constructor

        /// <summary>
        /// Vehicle repository constructor.
        /// </summary>
        public VehicleRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        #region Methods  

        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return mapper.Map<VehicleModelPoco>(await vehicleContext.VehicleModels.FindAsync(id));
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync(IPagingParameters paging, IVehicleFilter searchVehicle)
        {
            return mapper.Map<List<VehicleModelPoco>>(await vehicleContext.VehicleModels
                .Where(item => searchVehicle.CategoryId.HasValue ? item.VehicleCategoryId == searchVehicle.CategoryId : item != null)
                .OrderBy(item => item.Name)
                .ToPagedListAsync(paging.PageNumber,paging.PageSize));
        }

        public Task InsertVehicleAsync(IVehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);

            vehicleContext.VehicleModels.Add(mapper.Map<DAL.Entities.VehicleModel>(vehicleModel));

            return vehicleContext.SaveChangesAsync();
        }

        public Task UpdateVehicleAsync(IVehicleModel vehicleModel)
        {
            mapper.Map<DAL.Entities.VehicleModel>(vehicleModel);
            return vehicleContext.SaveChangesAsync();
        }

        public Task DeleteVehicleAsync(Guid id)
        {
            var oneVehicle = vehicleContext.VehicleModels.Find(id);
            vehicleContext.VehicleModels.Remove(oneVehicle);

            return vehicleContext.SaveChangesAsync();
        }

        #endregion
    }
}
