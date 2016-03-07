using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    /// <summary>
    /// Sorting parameters class.
    /// </summary>
    public class SortingParameters : ISortingParameters
    {
        #region Constructor

        /// <summary>
        /// Sorting parameters constructor.
        /// </summary>
        /// <param name="vehicleCategory">Vehicle category.</param>
        public SortingParameters(string vehicleCategory)
        {
            this.VehicleCategory = vehicleCategory;
        }

        #endregion

        /// <summary>
        /// Gets or sets vehicle category.
        /// </summary>
        public string VehicleCategory { get; set; }
    }
}
