using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    /// <summary>
    /// Paging parameters class.
    /// </summary>
    public class PagingParameters : IPagingParameters
    {
        /// <summary>
        /// Paging parameters constructor.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        public PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Gets or sets page number.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets page size.
        /// </summary>
        public int PageSize { get; set; }
    }
}
