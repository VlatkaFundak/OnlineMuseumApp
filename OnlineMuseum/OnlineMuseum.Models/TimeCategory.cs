using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuseum.Models.Common;

namespace OnlineMuseum.Models
{
    /// <summary>
    /// Time category class.
    /// </summary>
    public class TimeCategory: ITimeCategory
    {
        #region Properties

        /// <summary>
        /// Gest or sets Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gest or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        public string Abrv { get; set; }

        #endregion
    }
}
