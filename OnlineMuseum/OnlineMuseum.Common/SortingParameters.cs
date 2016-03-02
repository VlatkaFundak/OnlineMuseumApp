using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Common
{
    public class SortingParameters : ISortingParameters
    {
        public SortingParameters(string sortOrder)
        {
            this.SortOrder = sortOrder;
        }

        public string SortOrder { get; set; }
    }
}
