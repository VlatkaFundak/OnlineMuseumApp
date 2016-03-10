using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Repository;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Services.Common;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Services
{
    /// <summary>
    /// Category service class.
    /// </summary>
    public class CategoryService: ICategoryService
    {
        #region Fields

        /// <summary>
        /// Category repository.
        /// </summary>
        private ICategoryRepository categoryRepository;

        #endregion

        #region Constructor

        /// <summary>
        /// Category service constructor.
        /// </summary>
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        #endregion

        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns>Categories.</returns>
        public async Task<IEnumerable<IVehicleCategory>> GetCategoriesAsync()
        {
            return await categoryRepository.GetCategoriesAsync();
        }

        /// <summary>
        /// Gets one categore.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>One category.</returns>
        public async Task<IVehicleCategory> GetCategoryAsync(Guid id)
        {
            return await categoryRepository.GetCategoryAsync(id);
        }

        /// <summary>
        /// Inserts new category.
        /// </summary>
        /// <param name="category">Category.</param>
        /// <returns>Updated database.</returns>
        public Task InsertCategoryAsync(VehicleCategoryPoco category)
        {
            return categoryRepository.InsertCategoryAsync(category);
        }

    }
}
