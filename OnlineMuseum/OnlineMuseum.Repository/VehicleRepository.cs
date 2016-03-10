using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
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

        /// <summary>
        /// Mapper.
        /// </summary>
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

        /// <summary>
        /// Gets one vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One vehicle.</returns>
        public async Task<IVehicleModel> GetVehicleAsync(Guid id)
        {
            return mapper.Map<VehicleModelPoco>(await vehicleContext.VehicleModels.FindAsync(id));
        }

        /// <summary>
        /// Gets vehicles.
        /// </summary>
        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>
        /// <returns>Vehicles.</returns>
        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            var listOfVehicles = await vehicleContext.VehicleModels.ToListAsync();

            var filteredListOfVehicles = listOfVehicles
                .Where(item => filterVehicle.CategoryId.HasValue ? item.VehicleCategoryId == filterVehicle.CategoryId : item != null)
                .Where(item => String.IsNullOrEmpty(filterVehicle.FindVehicle) ? item != null : item.Name.Contains(filterVehicle.FindVehicle))
                .Where(item => filterVehicle.MakerId == Guid.Empty ? item != null : item.VehicleMakerId == filterVehicle.MakerId);

            var sortedList = filteredListOfVehicles.OrderBy(sorting.SortField + " " + sorting.SortOrder);
            var mappedList = mapper.Map<List<VehicleModelPoco>>(sortedList);
            var pagedList = mappedList.ToPagedList(paging.PageNumber, paging.PageSize);
            var pagedListOfVehicles = new StaticPagedList<VehicleModelPoco>(pagedList, pagedList.GetMetaData());

            return pagedListOfVehicles;
        }

        /// <summary>
        /// Instert new vehicle.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updates database.</returns>
        public Task InsertVehicleAsync(IVehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);
            vehicleContext.VehicleModels.Add(mapper.Map<DAL.Entities.VehicleModel>(vehicleModel));

            return vehicleContext.SaveChangesAsync();
        }

        /// <summary>
        /// Upade vehicles.
        /// </summary>
        /// <param name="vehicleModel">Vehicle model.</param>
        /// <returns>Updates database.</returns>
        public Task UpdateVehicleAsync(IVehicleModel vehicleModel)
        {
            mapper.Map<DAL.Entities.VehicleModel>(vehicleModel);
            return vehicleContext.SaveChangesAsync();
        }

        /// <summary>
        /// Delete vehicle.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Updated base.</returns>
        public Task DeleteVehicleAsync(Guid id)
        {
            var oneVehicle = vehicleContext.VehicleModels.Find(id);
            vehicleContext.VehicleModels.Remove(oneVehicle);

            return vehicleContext.SaveChangesAsync();
        }

        #endregion
    }
}
