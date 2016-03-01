using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Repository.Common
{
    public interface IMakerRepository
    {
        Task<IVehicleMaker> GetOneMakerAsync(Guid id);

        Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync();
    }
}
