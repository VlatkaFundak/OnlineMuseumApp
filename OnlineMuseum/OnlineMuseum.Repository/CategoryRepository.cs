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
    public class CategoryRepository: ICategoryRepository
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
        /// Category repository constructor.
        /// </summary>
        public CategoryRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return mapper.Map<IEnumerable<VehicleCategoryPoco>>(await vehicleContext.VehicleCategories.ToListAsync());
        }

        public async Task<IVehicleCategory> GetOneCategoryAsync(Guid id)
        {
            return mapper.Map<VehicleCategoryPoco>( await vehicleContext.VehicleCategories.FindAsync(id));
        }

        public Task InsertCategoryAsync(IVehicleCategory category)
        {
            category.Id = Guid.NewGuid();
            category.Abrv = category.Name.Substring(0, 3);            

            vehicleContext.VehicleCategories.Add(mapper.Map<DAL.Entities.VehicleCategory>(category));

            return vehicleContext.SaveChangesAsync();
        }
    }
}
