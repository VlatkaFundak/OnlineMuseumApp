using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Services.Common
{
    /// <summary>
    /// Category service interface.
    /// </summary>
     public interface ICategoryService
    {
        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns>Categories.</returns>
        Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync();

        /// <summary>
        /// Gets one categore.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>One category.</returns>
        Task<IVehicleCategory> GetOneCategoryAsync(Guid id);

        /// <summary>
        /// Inserts new category.
        /// </summary>
        /// <param name="category">Category.</param>
        /// <returns>Updated database.</returns>
        Task InsertCategoryAsync(VehicleCategoryPoco category);
    }
}
