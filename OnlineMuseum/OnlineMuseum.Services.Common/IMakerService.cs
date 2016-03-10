using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Services.Common
{
    /// <summary>
    /// Maker service interface.
    /// </summary>
    public interface IMakerService
    {
        /// <summary>
        /// Gets all makers.
        /// </summary>
        /// <returns>Makers.</returns>
        Task<IEnumerable<IVehicleMaker>> GetMakersAsync();

        /// <summary>
        /// Gets one maker.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One maker.</returns>
        Task<IVehicleMaker> GetMakerAsync(Guid id);

    }
}
