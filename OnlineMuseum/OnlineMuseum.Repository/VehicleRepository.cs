using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;
using OnlineMuseum.Models;
using OnlineMuseum.DAL;

namespace OnlineMuseum.Repository
{
    public class VehicleRepository
    {
        private VehicleContext VehicleContext;

        public VehicleRepository()
        {
            VehicleContext = new VehicleContext();        
        }

        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return await VehicleContext.VehicleModels.FindAsync(id);
        }

    }
}
