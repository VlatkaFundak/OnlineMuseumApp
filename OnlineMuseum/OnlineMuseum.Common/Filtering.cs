using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class Filtering
    {
        public Filtering(string searchVehicle)
        {
            this.SearchVehicle = searchVehicle;
        }

        public string SearchVehicle { get; set; }
    }
}
