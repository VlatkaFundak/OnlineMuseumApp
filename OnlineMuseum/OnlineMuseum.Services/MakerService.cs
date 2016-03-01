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
    public class MakerService: IMakerService
    {
        #region Fields

        private IMakerRepository makerRepository;

        #endregion

        #region Constructor

        public MakerService()
        {
            makerRepository = new MakerRepository();
        }

        #endregion
        
        public async Task<IEnumerable<IVehicleMaker>> GetAllMakersAsync()
        {
            return await makerRepository.GetAllMakersAsync();
        }

        public async Task<IVehicleMaker> GetOneMakerAsync(Guid id)
        {
            return await makerRepository.GetOneMakerAsync(id);
        }

    }
}
