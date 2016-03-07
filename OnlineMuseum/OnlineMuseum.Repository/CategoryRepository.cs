using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

using OnlineMuseum.DAL;
using OnlineMuseum.Models;
using OnlineMuseum.Common;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Mapping;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Repository
{
    /// <summary>
    /// Category repository class.
    /// </summary>
    public class CategoryRepository: ICategoryRepository
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
        /// Category repository constructor.
        /// </summary>
        public CategoryRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns>Categories.</returns>
        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return mapper.Map<IEnumerable<VehicleCategoryPoco>>(await vehicleContext.VehicleCategories.ToListAsync());
        }

        /// <summary>
        /// Gets one category.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Category.</returns>
        public async Task<IVehicleCategory> GetOneCategoryAsync(Guid id)
        {
            return mapper.Map<VehicleCategoryPoco>( await vehicleContext.VehicleCategories.FindAsync(id));
        }

        /// <summary>
        /// Inserts new category.
        /// </summary>
        /// <param name="category">Category.</param>
        /// <returns>Updated database.</returns>
        public Task InsertCategoryAsync(IVehicleCategory category)
        {
            category.Id = Guid.NewGuid();
            category.Abrv = category.Name.Substring(0, 3);            

            vehicleContext.VehicleCategories.Add(mapper.Map<DAL.Entities.VehicleCategory>(category));

            return vehicleContext.SaveChangesAsync();
        }

        #endregion
    }
}
