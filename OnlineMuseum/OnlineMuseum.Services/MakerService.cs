using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Repository;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Services.Common;
using OnlineMuseum.Repository.Common;

namespace OnlineMuseum.Services
{
    /// <summary>
    /// Maker service class.
    /// </summary>
    public class MakerService: IMakerService
    {
        #region Fields

        /// <summary>
        /// Maker repository.
        /// </summary>
        private IMakerRepository makerRepository;

        #endregion

        #region Constructor

        /// <summary>
        /// Maker service constructor.
        /// </summary>
        public MakerService()
        {
            makerRepository = new MakerRepository();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets all makers.
        /// </summary>
        /// <returns>Makers.</returns>
        public async Task<IEnumerable<IVehicleMaker>> GetMakersAsync()
        {
            return await makerRepository.GetMakersAsync();
        }

        /// <summary>
        /// Gets one maker.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>One maker.</returns>
        public async Task<IVehicleMaker> GetMakerAsync(Guid id)
        {
            return await makerRepository.GetMakerAsync(id);
        }

        #endregion

    }
}
