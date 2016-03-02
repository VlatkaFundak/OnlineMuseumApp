using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Common;
using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Repository.Common
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync();

        Task<IVehicleCategory> GetOneCategoryAsync(Guid id);
    }
}
