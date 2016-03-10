using System;
namespace OnlineMuseum.Common
{
    /// <summary>
    /// Sorting parameters interface.
    /// </summary>
    public interface ISortingParameters
    {
        /// <summary>
        /// Gets or sets sort order.
        /// </summary>
        string SortOrder { get; set; }

        /// <summary>
        /// Gets or sets sort field.
        /// </summary>
        string SortField { get; set; }
    }
}
