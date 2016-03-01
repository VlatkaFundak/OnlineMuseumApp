using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Services.Common
{
     public interface ICategoryService
    {

        Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync();

        Task<IVehicleCategory> GetOneCategoryAsync(Guid id);
    }
}
