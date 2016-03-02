using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class PagingParameters : IPagingParameters
    {
        public PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }
}
