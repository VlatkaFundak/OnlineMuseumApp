using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList.EntityFramework;
using PagedList;
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

        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle)
        {
            var listOfVehicles = mapper.Map<List<VehicleModelPoco>>(await vehicleContext.VehicleModels
                .Where(item => filterVehicle.CategoryId.HasValue ? item.VehicleCategoryId == filterVehicle.CategoryId : item != null)
                .Where(item => String.IsNullOrEmpty(filterVehicle.FindVehicle) ? item != null : item.Name.Contains(filterVehicle.FindVehicle))
                .Where(item => filterVehicle.MakerId == Guid.Empty ? item != null : item.VehicleMakerId == filterVehicle.MakerId)
                .OrderBy(item => item.Name)
                .ToListAsync());

            var pagedList = listOfVehicles.ToPagedList(paging.PageNumber, paging.PageSize);
            var pagedListOfVehicles = new StaticPagedList<VehicleModelPoco>(pagedList, pagedList.GetMetaData());

            return pagedListOfVehicles;
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
