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
        /// <param name="sortOrder">Sort order.</param>
        /// <param name="sortField">Sort field.</param>
        public SortingParameters(string sortField, string sortOrder)
        {
            this.SortOrder = sortOrder;
            this.SortField = sortField;
        }

        #endregion

        /// <summary>
        /// Gets or sets sort order.
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// Gets or sets sort field.
        /// </summary>
        public string SortField { get; set; }

    }
}
