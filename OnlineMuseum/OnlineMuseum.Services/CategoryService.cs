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
    public class CategoryService: ICategoryService
    {
        #region Fields

        private ICategoryRepository categoryRepository;

        #endregion

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }


        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return await categoryRepository.GetAllCategoriesAsync();
        }

        public async Task<IVehicleCategory> GetOneCategoryAsync(Guid id)
        {
            return await categoryRepository.GetOneCategoryAsync(id);
        }

        public Task InsertCategoryAsync(VehicleCategoryPoco category)
        {
            return categoryRepository.InsertCategoryAsync(category);
        }

    }
}
