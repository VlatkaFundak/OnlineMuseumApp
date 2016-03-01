using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Services.Common
{
    public interface IMakerService
    {

        Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync();

        Task<IVehicleMaker> GetOneMakerAsync(Guid id);

    }
}
