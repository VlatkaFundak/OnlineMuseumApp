using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class VehicleFilter : IVehicleFilter
    {
        public VehicleFilter(Guid categoryId, string findVehicle, Guid? makerId)
        {
            this.CategoryId = categoryId;
            this.FindVehicle = findVehicle;
            this.MakerId = makerId.HasValue ? makerId.Value : Guid.Empty;
        }

        public Guid? CategoryId { get; set; }

        public string FindVehicle { get; set; }

        public Guid? MakerId { get; set; }

    }
}
