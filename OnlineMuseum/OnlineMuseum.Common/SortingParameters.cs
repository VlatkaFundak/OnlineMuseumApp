using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class SortingParameters : ISortingParameters
    {
        #region Constructor

        public SortingParameters(string vehicleMaker)
        {
            this.VehicleMaker = vehicleMaker;
        }

        #endregion

        public string VehicleMaker { get; set; }
    }
}
