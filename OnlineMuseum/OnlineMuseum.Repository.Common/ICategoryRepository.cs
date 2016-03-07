using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Common;
using OnlineMuseum.Models;
using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Repository.Common
{
    /// <summary>
    /// Category repository interface.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns>Categories.</returns>
        Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync();

        /// <summary>
        /// Gets one category.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Category.</returns>
        Task<IVehicleCategory> GetOneCategoryAsync(Guid id);

        /// <summary>
        /// Inserts new category.
        /// </summary>
        /// <param name="category">Category.</param>
        /// <returns>Updated database.</returns>
        Task InsertCategoryAsync(IVehicleCategory category);
    }
}
