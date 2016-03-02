using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class VehicleFilter : IVehicleFilter
    {
        public VehicleFilter(Guid categoryId, string name)
        {
            this.CategoryId = categoryId;
            this.Name = name;
        }

        public Guid? CategoryId { get; set; }

        public string Name { get; set; }
    }
}
