using System;
namespace OnlineMuseum.Common
{
    public interface IPagingParameters
    {
        /// <summary>
        /// Gets or sets page number.
        /// </summary>
        int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets page size.
        /// </summary>
        int PageSize { get; set; }
    }
}
