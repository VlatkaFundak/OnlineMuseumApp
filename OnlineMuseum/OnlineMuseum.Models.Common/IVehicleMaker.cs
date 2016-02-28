using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuseum.Models.Common
{
    /// <summary>
    /// Vehicle maker interface.
    /// </summary>
    public interface IVehicleMaker
    {
        #region Properties

        /// <summary>
        /// Gest or sets Id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gest or sets name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets abreviaton.
        /// </summary>
        string Abrv { get; set; }

        #endregion

    }
}
