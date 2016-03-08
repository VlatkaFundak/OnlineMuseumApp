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
        /// <param name="vehicleMakerSort">Vehicle category.</param>
        public SortingParameters(string vehicleMakerSort)
        {
            this.VehicleMakerSort = vehicleMakerSort;
        }

        #endregion

        /// <summary>
        /// Gets or sets vehicle category.
        /// </summary>
        public string VehicleMakerSort { get; set; }
    }
}
