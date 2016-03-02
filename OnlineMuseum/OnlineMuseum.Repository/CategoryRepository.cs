using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using OnlineMuseum.DAL;
using OnlineMuseum.Models;
using OnlineMuseum.Common;
using OnlineMuseum.Models.Common;
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

        #endregion

        #region Constructor

        /// <summary>
        /// Category repository constructor.
        /// </summary>
        public CategoryRepository()
        {
            vehicleContext = new VehicleContext();        
        }

        #endregion

        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return await vehicleContext.VehicleCategories.ToListAsync();
        }

        public async Task<IVehicleCategory> GetOneCategoryAsync(Guid id)
        {
            return await vehicleContext.VehicleCategories.FindAsync(id);
        }

        public Task InsertCategoryAsync(VehicleCategory category)
        {
            category.Id = Guid.NewGuid();
            category.Abrv = category.Name.Substring(0, 3);            

            vehicleContext.VehicleCategories.Add(category);

            return vehicleContext.SaveChangesAsync();
        }
    }
}
