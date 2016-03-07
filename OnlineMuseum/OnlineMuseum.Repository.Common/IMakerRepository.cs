using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Repository.Common
{
    /// <summary>
    /// Maker repository interface.
    /// </summary>
    public interface IMakerRepository
    {
        /// <summary>
        /// Gets one maker.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Maker.</returns>
        Task<IVehicleMaker> GetOneMakerAsync(Guid id);

        /// <summary>
        /// Gets all makers.
        /// </summary>
        /// <returns>Makers.</returns>
        Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync();
    }
}
